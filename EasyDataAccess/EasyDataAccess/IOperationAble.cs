using System.Collections.Generic;
using System.Data;

namespace EasyDataAccess
{
    /// <summary>
    /// 操作接口定义
    /// </summary>
    public  interface  IOperationAble<T>
    {
        /// <summary>
        /// 执行无查询
        /// </summary>
        /// <returns></returns>
        int ExecuteNoQuery();

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        List<T> Query();


        /// <summary>
        /// 返回查询结构
        /// </summary>
        /// <returns></returns>
        DataTable QueryTable();


    }
}
