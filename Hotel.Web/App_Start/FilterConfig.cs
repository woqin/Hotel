using Hotel.Web.App_Start.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Web.App_Start
{
    /// <summary>
    /// 过滤器配置
    /// </summary>
    public static class FilterConfig
    {
        /// <summary>
        /// 过滤器注册
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterFilters(GlobalFilterCollection filters)
        {
            //添加全局异常过滤器
            filters.Add(new HandleExceptionFilterAttribute());
        }
    }
}