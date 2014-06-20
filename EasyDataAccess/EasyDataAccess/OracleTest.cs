using System;
using System.Diagnostics;

namespace EasyDataAccess
{
     public  class OracleTest
    {
         /// <summary>
         /// 
         /// </summary>
         private const string DbConnection = "data source=CCN1;User Id=develop;Password=develop;";


         readonly DbContext dbContext = new DbContext("System.Data.OracleClient", DbConnection);


        /// <summary>
        /// 新增调试
        /// </summary>
        public void InsertDebug()
        {
            var ran = new Random();

            int age = ran.Next(21, 50);
            string sql = "insert into usercenter(username,sex,age) values('" + Guid.NewGuid() + "','男','" + age + "')";

            Debug.WriteLine(dbContext.ExecuteNoQuery(sql));
        }



        private void TestInsert()
        {
            TestHelper.TimerAction(InsertDebug);
        }

    }
}
