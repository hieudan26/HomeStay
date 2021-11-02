using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay.Class
{
    public static class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
        public static int GlobalRoomId { get; private set; }
        public static void SetGlobalRoomId(int rid)
        {
            GlobalRoomId = rid;
        }
        public static DataTable GlobalDataTableOver { get; private set; }
        public static void SetGlobalDataTableOver(DataTable dt)
        {
            GlobalDataTableOver = dt;
        }
    }
}
