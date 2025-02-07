using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    internal class Access
    {
        private readonly SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=Proyecto;Integrated Security=True;");
        SqlTransaction tx;
        void Open()
        {
            cn.Open();
        }
        void Close()
        {
            cn.Close();
        }
        void StartTX()
        {
            tx = cn.BeginTransaction();
        }
        void AcceptTX()
        {
            tx.Commit();
        }
        void CancelTX()
        {
            tx?.Rollback();
        }

        internal int Writer(string query, SqlParameter[] sp)
        {
            int ar;
            try
            {
                Open();
                StartTX();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = query
                };
                cmd.Parameters.AddRange(sp);
                AcceptTX();
                ar = cmd.ExecuteNonQuery();
            }
            catch
            {
                CancelTX();
                ar = -1;
            }
            finally
            {
                Close();
            }
            return ar;
        }
        internal DataTable Read(string query, SqlParameter[] sp)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand
                    {
                        Connection = cn,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = query
                    }
                };
                if (sp != null)
                    adapter.SelectCommand.Parameters.AddRange(sp);
                adapter.Fill(dt);
            }
            finally
            {
                Close();
            }
            return dt;
        }

        internal DataTable Read(string query, SqlParameter[] sp, string archive)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand
                    {
                        Connection = cn,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = query
                    }
                };
                if (sp != null)
                    adapter.SelectCommand.Parameters.AddRange(sp);
                adapter.Fill(dt);
            }
            catch
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml($"{archive}.xml");
                dt = dataSet.Tables[0];
            }
            finally
            {
                Close();
            }
            return dt;
        }

        internal string ReadData(string query, SqlParameter[] sp)
        {
            string data = null;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = query
                };
                if (sp != null)
                    cmd.Parameters.AddRange(sp);
                object result = cmd.ExecuteScalar();
                data = result?.ToString();
            }
            finally
            {
                Close();
            }
            return data;
        }

        internal void BackUpXML(string query, SqlParameter[] sp, string archive)
        {
            try
            {
                Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand()
                };
                adapter.SelectCommand.Connection = cn;
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = query;
                if (sp != null)
                    adapter.SelectCommand.Parameters.AddRange(sp);
                adapter.Fill(ds, archive);
                ds.WriteXml($"{archive}.xml");
            }
            catch
            {
                throw new Exception("Error al realizar la copia de seguridad");
            }
            finally
            {
                Close();
            }
        }
    }
}
