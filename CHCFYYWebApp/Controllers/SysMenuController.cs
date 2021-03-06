﻿using DLL.Models.MainDB;
using CHCFYYWebApp.Controllers;
using CHCFYYWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHCFYYWebApp.Controllers
{
    [LoginValidate]
    public class SysMenuController : BaseController<SYS_MENU_INFOModel>
    {
        // GET: SysMenu
        public ActionResult List()
        {
            return View(_pageInfo);
        }

        public ActionResult Query(PageModel<SYS_MENU_INFOModel> Model)
        {
            _pageInfo = Model;
            var result = Model.QueryModel.GetList(Model.QueryModel);
            if (result.IsSuccess)
            {
                _pageInfo.QueryData = result.Data;
                return View("List", _pageInfo);
            }
            else
            {
                return SysErro(result.Message);
            }
        }

        public ActionResult Create()
        {
            return View(new SYS_MENU_INFOModel());
        }

        [HttpPost]
        public ActionResult Create(SYS_MENU_INFOModel Model)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            var resualt = Model.Insert(Model, GetLoginUser());
            if (resualt.IsSuccess)
            {
                return SysInfo("/SysMenu/List");
            }
            else
            {
                return SysErro(resualt.Message);
            }
        }

        public ActionResult Edit(long id)
        {
            var resualt = new SYS_MENU_INFOModel().GetEnetityByID(id);
            if (resualt.IsSuccess)
            {
                //操作成功
                return View(resualt.Data);
            }
            else
            {
                //操作失败
                return SysErro(resualt.Message);
            }
        }

        [HttpPost]
        public ActionResult Edit(SYS_MENU_INFOModel Model)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            var resualt = Model.Update(Model, GetLoginUser());
            if (resualt.IsSuccess)
            {
                return SysInfo("/SysMenu/List");
            }
            else
            {
                return SysErro(resualt.Message);
            }
        }

        public ActionResult Delete(long id)
        {
            var resualt = new SYS_MENU_INFOModel().Delete(id, GetLoginUser());
            if (resualt.IsSuccess)
            {
                return SysInfo("/SysMenu/List");
            }
            else
            {
                return SysErro(resualt.Message);
            }
        }
        
        /// <summary>
        /// 根据菜单级别获取上级菜单
        /// </summary>
        /// <param name="MenuLevel"></param>
        /// <param name="selectedvalue"></param>
        /// <returns></returns>
        public ActionResult GetUpMenuInfo(string MenuLevel)
        {
            List<SYS_MENU_INFOModel> SlectItemList = null;
            try
            {
                SlectItemList = SYS_MENU_INFOModel.GetUpMenuListByLevel(MenuLevel);
            }
            catch
            { }
            return Json(SlectItemList,JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据菜单级别获取上级菜单
        /// </summary>
        /// <param name="MenuLevel"></param>
        /// <param name="selectedvalue"></param>
        /// <returns></returns>
        public static IEnumerable<SelectListItem> GetUpMenuList(string MenuLevel, string selectedvalue)
        {
            IEnumerable<SelectListItem> SlectItemList = null;
            try
            {
                var TypeList = SYS_MENU_INFOModel.GetUpMenuListByLevel(MenuLevel);
                if (TypeList != null)
                {
                    SlectItemList = TypeList.Select(p => new SelectListItem()
                    {
                        Text = p.MENU_NAME,
                        Value = p.MENU_CODE,
                        Selected = (p.MENU_CODE.Trim().ToLower().Equals(selectedvalue.Trim().ToLower()))
                    }).ToList();
                }
            }
            catch
            { }
            return SlectItemList;
        }

        /// <summary>
        /// 根据菜单代码获取菜单名称
        /// </summary>
        /// <returns></returns>
        public static string GetMenuNameBycode(string menucode)
        {
            string menuName = "";
            try
            {
                menuName = SYS_MENU_INFOModel.GetMenuNameByCode(menucode);
            }
            catch
            { }
            return menuName;
        }
    }
}