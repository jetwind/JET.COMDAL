using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EasyDataAccess
{
    public class DbContext:IOperationAble
    {


        /*
            System.Data.SqlClient 提供程序是用于 SQL Server 的默认 .NET Framework 数据提供程序。
            System.Data.OleDb 提供程序是用于 OLE DB 的 .NET Framework 数据提供程序。
            System.Data.Odbc 提供程序是用于 ODBC 的 .NET Framework 数据提供程序。
            System.Data.OracleClient 提供程序是用于 Oracle 的 .NET Framework 数据提供程序。
         */


        /// <summary>
        /// 驱动名称
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbCommand _DbCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbConnection _DbConnection { get; set; }

        /// <summary>
        /// 初始化数据连接对象
        /// </summary>
        /// <param name="providerName">数据驱动名称</param>
        public DbContext(string providerName)
        {
            this.ProviderName = providerName;
            DbProviderFactory dbProviderFactory= DbProviderFactories.GetFactory(providerName);
            if (dbProviderFactory == null)
            {
                throw new Exception("创建DbProvider失败，请确认DbProviderName正确且存在！");
            }
            _DbConnection = dbProviderFactory.CreateConnection();
            _DbCommand = dbProviderFactory.CreateCommand();

        }


        /// <summary>
        /// 初始化数据连接对象
        /// </summary>
        /// <param name="providerName">数据驱动名称</param>
        /// <param name="connectionString"></param>
        public DbContext(string providerName,string connectionString)
        {
            this.ProviderName = providerName;
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(providerName);
            if (dbProviderFactory == null)
            {
                throw new Exception("创建DbProvider失败，请确认DbProviderName正确且存在！");
            }
            _DbConnection = dbProviderFactory.CreateConnection();
            _DbConnection.ConnectionString = connectionString;
            _DbCommand = dbProviderFactory.CreateCommand();

        }





        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="execSql"></param>
        /// <returns></returns>
        public int ExecuteNoQuery(string execSql)
        {
            try
            {
               
                _DbCommand.CommandText = execSql;
                _DbCommand.CommandType = CommandType.Text;
                _DbCommand.Connection = _DbConnection;
                

                _DbConnection.Open();
                return _DbCommand.ExecuteNonQuery();
            }
            finally
            {
                _DbConnection.Close();
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public List<T> Query()
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable QueryTable()
        {
            throw new NotImplementedException();
        }
    }
}
