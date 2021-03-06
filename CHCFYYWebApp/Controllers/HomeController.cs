﻿using DLL.MAINBussiness;
using DLL.Models.MainDB;
using CHCFYYWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CHCFYApp;

namespace CHCFYYWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [LoginValidate]
        public ActionResult Index()
        {
            //登录用户信息
            UserModel loginuser = (UserModel)Session[ConstDictionary.LoginUser];
            //菜单信息
            List<TreeModel> treeItem = new List<TreeModel>();
            #region 获取菜单信息
            var menulist = UserModel.GetUserMenusByUserId(loginuser);
            if (menulist.IsSuccess)
            {
                treeItem = menulist.Data.Where(p => p.CODE_FOR_MENU_LEVEL.Equals("MENU_LEVEL_1") && p.CODE_FOR_STATUS.Equals("1"))
                    .Select(v => new TreeModel()
                    {
                        id = v.MENU_ID.ToString(),
                        code = v.MENU_CODE,
                        text = v.MENU_NAME
                    }).ToList();
                for (int i = 0; i < treeItem.Count; i++)
                {
                    treeItem[i].menu = menulist.Data.Where(p => p.CODE_FOR_MENU_LEVEL.Equals("MENU_LEVEL_2") && p.CODE_FOR_STATUS.Equals("1") && p.MENU_UPMENU.Equals(treeItem[i].code))
                        .Select(v => new MenuInfo()
                        {
                            id = v.MENU_ID.ToString(),
                            code = v.MENU_CODE,
                            text = v.MENU_NAME
                        }).ToList();
                    for (int j = 0; j < treeItem[i].menu.Count; j++)
                    {
                        treeItem[i].menu[j].items = menulist.Data.Where(p => p.CODE_FOR_MENU_LEVEL.Equals("MENU_LEVEL_3") && p.CODE_FOR_STATUS.Equals("1") && p.MENU_UPMENU.Equals(treeItem[i].menu[j].code))
                            .Select(v => new FuncInfo()
                            {
                                id = v.MENU_ID.ToString(),
                                code = v.MENU_CODE,
                                text = v.MENU_NAME,
                                href = v.MENU_URL
                            }).ToList();
                    }
                }
            }
            #endregion
            treeItem = treeItem.OrderBy(p => p.id).ToList();
            ViewBag.menuList = treeItem;
            ViewBag.menuStr = Newtonsoft.Json.JsonConvert.SerializeObject(treeItem);
            return View(loginuser);
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            //清除登录用户信息
            Session.Remove(ConstDictionary.LoginUser);
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = UserDAL.LoginValidate(new UserModel() {  USER_USERID = model.USER_USERID,  USER_PASSWORD = model.USER_PASSWORD });
            if (result.IsSuccess)
            {
                //设置用户登录信息
                Session.Add(ConstDictionary.LoginUser, result.Data);
                return Redirect("/Home/Index");
            }
            else
            {
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
        }
    }
}