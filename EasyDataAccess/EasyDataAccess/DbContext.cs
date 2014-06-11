using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EasyDataAccess
{
    public class DbContext<T>:IOperationAble<T>
    {
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <returns></returns>
        public int ExecuteNoQuery()
        {
            
            _DbConnection.Open();
            
            _DbConnection.Close();
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T> Query()
        {
            throw new NotImplementedException();
        }

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
