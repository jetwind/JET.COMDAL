using System.Collections.Generic;
using System.Data;

namespace EasyDataAccess
{
    /// <summary>
    /// 操作接口定义
    /// </summary>
    public  interface  IOperationAble
    {
        /// <summary>
        /// 执行无查询
        /// </summary>
        /// <returns></returns>
        int ExecuteNoQuery(string execSql);



        /// <summary>
        /// 返回查询结构
        /// </summary>
        /// <returns></returns>
        DataTable QueryTable();


    }
}
