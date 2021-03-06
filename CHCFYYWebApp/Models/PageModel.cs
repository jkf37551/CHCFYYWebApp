﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCFYYWebApp.Models
{
    /// <summary>
    /// 页面模型
    /// </summary>
    public class PageModel<T>
    {
        /// <summary>
        /// 查询模型
        /// </summary>
        public T QueryModel { get; set; }
        /// <summary>
        /// 查询结果
        /// </summary>
        public List<T> QueryData { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int Total_Recoder { get; set; }
        /// <summary>
        /// 每页显示数(最大)
        /// </summary>
        public int Page_Size { get; set; }
        /// <summary>
        /// 总页面数
        /// </summary>
        public int Total_Page { get; set; }
        /// <summary>
        /// 当前页面ID(要查询页面ID)
        /// </summary>
        public int Current_PageId{get;set;}
        
        /// <summary>
        /// 分页查询控制器
        /// </summary>
        public string Controll { get; set; }
        /// <summary>
        /// 分页查询action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 模型SeesionKey(用于保存和设置查询信息)
        /// </summary>
        public string Key_Model { get; set; }
    }
}