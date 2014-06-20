using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EasyDataAccess
{

    public class SqlServerTest
    {

        private const string DbConnection = "Data Source=CCN-ZY;Initial Catalog=TestDB;User ID=sa;Password=001123;Persist Security Info=True;";

        readonly DbContext dbContext = new DbContext("System.Data.SqlClient", DbConnection);


        /// <summary>
        /// 新增调试
        /// </summary>
        public void InsertDebug()
        {
            Random ran=new Random();

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
