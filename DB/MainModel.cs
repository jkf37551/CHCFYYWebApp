using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    /// <summary>
    /// 系统类型词典
    /// </summary>
    public class MAIN_SYS_TYPE
    {
        /// <summary>
        /// TYPE_ID
        /// </summary>
        [Display(Name = "TYPE_ID")]
        [Key]
        public long TYPE_ID { get; set; }
        /// <summary>
        /// 类型代码
        /// </summary>
        [Display(Name = "类型代码")]
        [StringLength(50)]
        [Key]
        public string TYPE_CODE { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        [Display(Name = "类型名称")]
        [StringLength(250)]
        public string TYPE_DESC { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime TYPE_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string TYPE_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        public DateTime TYPE_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string TYPE_LASTUPDATEUSER { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string TYPE_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string TYPE_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string TYPE_COL3 { get; set; }
    }
    /// <summary>
    /// 系统字典表
    /// </summary>
    public class MAIN_SYS_CODE
    {
        /// <summary>
        /// CODE_ID
        /// </summary>
        [Display(Name = "CODE_ID")]
        [Key]
        public long CODE_ID { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name = "代码")]
        [StringLength(50)]
        public string CODE_CODE { get; set; }
        /// <summary>
        /// 代码名称
        /// </summary>
        [Display(Name = "代码名称")]
        [StringLength(250)]
        public string CODE_NAME { get; set; }
        /// <summary>
        /// 代码描述
        /// </summary>
        [Display(Name = "代码描述")]
        [StringLength(250)]
        public string CODE_DESC { get; set; }
        /// <summary>
        /// 代码类型
        /// </summary>
        [Display(Name = "代码类型")]
        [StringLength(50)]
        public string TYPE_FOR_CODE { get; set; }
        /// <summary>
        /// 代码状态
        /// </summary>
        [Display(Name = "代码状态")]
        [StringLength(50)]
        public string CODE_FOR_STATUS { get; set; }
        /// <summary>
        /// 排序ID
        /// </summary>
        [Display(Name = "排序ID")]
        public int CODE_ORDERID { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime CODE_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string CODE_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        public DateTime CODE_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string CODE_LASTUPDATEUSER { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string CODE_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string CODE_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string CODE_COL3 { get; set; }
    }
    /// <summary>
    /// 系统信息表
    /// </summary>
    public class MAIN_SYS_INFO
    {
        /// <summary>
        /// SYS_ID
        /// </summary>
        [Display(Name = "SYS_ID")]
        [Key]
        public long SYS_ID { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name = "版本号")]
        [StringLength(50)]
        public string SYS_VSERION { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "更新内容")]
        public string SYS_UPDATE_CONTENT { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Display(Name = "更新时间")]
        public DateTime SYS_UPDATE_TIME { get; set; }
        /// <summary>
        /// 更新类型
        /// </summary>
        [Display(Name = "更新类型")]
        [StringLength(50)]
        public string CODE_FOR_SYSTYPE { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime SYS_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string SYS_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        public DateTime SYS_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string SYS_LASTUPDATEUSER { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string SYS_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string SYS_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string SYS_COL3 { get; set; }
    }
    /// <summary>
    /// 系统菜单表
    /// </summary>
    public class MAIN_MENU_INFO
    {
        /// <summary>
        /// MENU_ID
        /// </summary>
        [Display(Name = "MENU_ID")]
        [Key]
        public long MENU_ID { get; set; }
        /// <summary>
        /// 菜单代码
        /// </summary>
        [Display(Name = "菜单代码")]
        [StringLength(50)]
        public string MENU_CODE { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        [Display(Name = "菜单名称")]
        [StringLength(50)]
        public string MENU_NAME { get; set; }
        /// <summary>
        /// 菜单地址
        /// </summary>
        [Display(Name = "菜单地址")]
        [StringLength(250)]
        public string MENU_URL { get; set; }
        /// <summary>
        /// 菜单级别
        /// </summary>
        [Display(Name = "菜单级别")]
        [StringLength(50)]
        public string CODE_FOR_MENULEVEL { get; set; }
        /// <summary>
        /// 上级菜单ID
        /// </summary>
        [Display(Name = "上级菜单ID")]
        [StringLength(50)]
        public string MENU_UPID { get; set; }
        /// <summary>
        /// 菜单状态
        /// </summary>
        [Display(Name = "菜单状态")]
        [StringLength(50)]
        public string CODE_FOR_STATUS { get; set; }
        /// <summary>
        /// 排序ID
        /// </summary>
        [Display(Name = "排序ID")]
        public int MENU_ORDERID { get; set; }
        /// <summary>
        /// 菜单模块（ACTION预留）
        /// </summary>
        [Display(Name = "菜单模块")]
        [StringLength(50)]
        public string MENU_MODEL { get; set; }
        /// <summary>
        /// 菜单图标(预留)
        /// </summary>
        [Display(Name = "菜单图标")]
        [StringLength(250)]
        public string MENU_IMAGE_URL { get; set; }
        /// <summary>
        /// 导出
        /// </summary>
        [Display(Name = "导出")]
        public int MENU_EXPORT { get; set; }
        /// <summary>
        /// 打印
        /// </summary>
        [Display(Name = "打印")]
        public int MENU_PRINTF { get; set; }
        /// <summary>
        /// 新增
        /// </summary>
        [Display(Name = "新增")]
        public int MENU_INSERT { get; set; }
        /// <summary>
        /// 编辑
        /// </summary>
        [Display(Name = "编辑")]
        public int MENU_EDIT { get; set; }
        /// <summary>
        /// 删除
        /// </summary>
        [Display(Name = "删除")]
        public int MENU_DELETE { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime MENU_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string MENU_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        public DateTime MENU_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string MENU_LASTUPDATEUSER { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string MENU_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string MENU_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string MENU_COL3 { get; set; }
    }
    /// <summary>
    /// 用户表
    /// </summary>
    public class MAIN_USERS
    {
        /// <summary>
        /// ID
        /// </summary>
        [Display(Name = "ID")]
        [Key]
        public long ID { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        [StringLength(50)]
        [Key]
        public string USER_USERID { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Display(Name = "密码")]
        [StringLength(50)]
        public string USER_PASSWORD { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name = "姓名")]
        [StringLength(50)]
        public string USER_NAME { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        [StringLength(50)]
        public string CODEID_FOR_USERSTATUS { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [Display(Name = "部门")]
        [StringLength(50)]
        public string USER_DEPARTMENTID { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        [Display(Name = "职位")]
        [StringLength(50)]
        public string USER_POSTID { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        [StringLength(50)]
        public string CODEID_FOR_SEX { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [Display(Name = "出生日期")]
        [StringLength(50)]
        public string USER_BIRTHDAY { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [Display(Name = "电话")]
        [StringLength(50)]
        public string USER_TELPHONE { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        [Display(Name = "手机")]
        [StringLength(50)]
        public string USER_MOBILEPHONE { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name = "地址")]
        [StringLength(250)]
        public string USER_ADDRESS { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [Display(Name = "电子邮箱")]
        [StringLength(200)]
        public string USER_EMAIL { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        [Display(Name = "身份证号")]
        [StringLength(50)]
        public string USER_CARD { get; set; }
        /// <summary>
        /// 公司
        /// </summary>
        [Display(Name = "公司")]
        [StringLength(50)]
        public string BUKRS { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string USER_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string USER_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string USER_COL3 { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [StringLength(50)]
        public string USER_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string USER_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Display(Name = "最后更新时间")]
        public DateTime USER_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string USER_LASTUPDATEUSER { get; set; }
    }
    /// <summary>
    /// 角色表
    /// </summary>
    public class MAIN_ROLES
    {
        /// <summary>
        /// ROLE_ID
        /// </summary>
        [Display(Name = "ROLE_ID")]
        [Key]
        public long ROLE_ID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [Display(Name = "角色名称")]
        [StringLength(50)]
        public string ROLE_NAME { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        [StringLength(50)]
        public string CODEID_FOR_STATUS { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string ROLE_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string ROLE_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string ROLE_COL3 { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime ROLE_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string ROLE_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        [StringLength(50)]
        public DateTime ROLE_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string ROLE_LASTUPDATEUSER { get; set; }
    }
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class MAIN_USER_ROLES
    {
        /// <summary>
        /// ID
        /// </summary>
        [Display(Name = "URID")]
        [Key]
        public long URID { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        [Display(Name = "用户")]
        [StringLength(50)]
        public string USERID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        [Display(Name = "角色ID")]
        public int ROLEID { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string UR_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string UR_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string UR_COL3 { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime UR_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string UR_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        public DateTime UR_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string UR_LASTUPDATEUSER { get; set; }
    }
    /// <summary>
    /// 角色菜单权限表
    /// </summary>
    public class MAIN_ROLE_MENUS
    {
        /// <summary>
        /// RMID
        /// </summary>
        [Display(Name = "RMID")]
        [Key]
        public long RMID { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Display(Name = "角色ID")]
        [StringLength(50)]
        public int ROLEID { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        [Display(Name = "菜单ID")]
        [StringLength(50)]
        public int MENUID { get; set; }
        /// <summary>
        /// 预留字段1
        /// </summary>
        [Display(Name = "预留字段1")]
        [StringLength(50)]
        public string RM_COL1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// </summary>
        [Display(Name = "预留字段2")]
        [StringLength(50)]
        public string RM_COL2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// </summary>
        [Display(Name = "预留字段3")]
        [StringLength(50)]
        public string RM_COL3 { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime RM_CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(50)]
        public string RM_CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        [Display(Name = "最后更新日期")]
        public DateTime RM_LASTUPDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Display(Name = "最后更新人")]
        [StringLength(50)]
        public string RM_LASTUPDATEUSER { get; set; }
    }
    
}
