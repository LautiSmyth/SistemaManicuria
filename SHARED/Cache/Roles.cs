using System.Collections.Generic;

namespace SHARED.Cache
{
    public static class Roles
    {
        private static List<BE.Role> list;

        public static List<BE.Role> List
        {
            get { return list; }
            set { list = value; }
        }

    }
}
