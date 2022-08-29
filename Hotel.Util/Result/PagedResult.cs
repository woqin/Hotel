using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Util.Result
{
    /// <summary>
    /// 分页通用数据结果
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class PagedResultn<TModel>:DataResult<TModel>
    {
        /// <summary>
        /// 当前页索引
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页记录条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 数据记录总条数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 当前页数据
        /// </summary>
        public List<TModel> CurrentPageData { get; set; }
        public PagedResultn(int pageIndex, int pageSize, int totalCount, List<TModel> currentPageData)
        {
            IsSuccess = true;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            CurrentPageData = currentPageData;
        }
        public PagedResultn(int totalCount,List<TModel> currentPageData)
        {
            IsSuccess=true;
            TotalCount=totalCount;
            CurrentPageData=currentPageData;
        }
    }
}
