using Hotel.Util.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Web.App_Start.Filters
{
    /// <summary>
    /// 异常处理过滤器
    /// </summary>
    public class HandleExceptionFilterAttribute : IExceptionFilter
    {
        /// <summary>
        /// 处理异常
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnException(ExceptionContext filterContext)
        {
            //判断当前的请求是否为Ajax
            bool isAjaxRequest = filterContext.HttpContext.Request.IsAjaxRequest();
            if (isAjaxRequest)
            {
                filterContext.Result = new JsonResult()
                {
                    Data = new DataResult<string>(errorMessage: "系统发生错误")
                };
            }
            else
            {
                filterContext.Result = new RedirectResult("/Error");
            }
            //异常发生后，进行处理以后，需要告诉应用程序，这个异常已经处理过了
            filterContext.ExceptionHandled = true;
        }
    }
}