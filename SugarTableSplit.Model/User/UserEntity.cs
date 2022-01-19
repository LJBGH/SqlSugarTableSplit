using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace SugarTableSplit.Model.User
{
    /// <summary>
    /// 用户表
    /// </summary>
    [SplitTable(SplitType.Day)]    //按天分表 （自带分表支持 年、季、月、周、日）
    [SugarTable("sys_User_{year}{month}{day}")]  //生成表名格式 3个变量必须要有
    public class UserEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true/*, IsIdentity = true*/, ColumnDescription = "主键Id")]
        [DisplayName("主键Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [DisplayName("账号")]
        [SugarColumn(IsNullable = true, Length = 50, ColumnDescription = "账号")]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("密码")]
        [SugarColumn(IsNullable = true, Length = 50, ColumnDescription = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 人员姓名
        /// </summary>
        [DisplayName("人员姓名")]
        [SugarColumn(IsNullable = true, Length = 50, ColumnDescription = "人员姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [DisplayName("工号")]
        [SugarColumn(IsNullable = true, Length = 50, ColumnDescription = "工号")]
        public string JobNumber { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [DisplayName("部门")]
        [SugarColumn(IsNullable = true, Length = 50, ColumnDescription = "部门")]
        public string Department { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [DisplayName("职位")]
        [SugarColumn(IsNullable = true, Length = 50, ColumnDescription = "职位")]
        public string Position { get; set; }






        #region   通用字段
        /// <summary>
        /// 创建人Id
        /// </summary>
        [DisplayName("创建人Id")]
        [SugarColumn(ColumnDescription = "创建人Id")]
        public Guid CreatedId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SplitField] //分表字段， 在插入的时候会根据这个字段插入哪个表，在更新删除的时候用这个字段找出相关表
        [DisplayName("创建时间")]
        [SugarColumn(IsNullable = true, ColumnDescription = "创建时间")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 最后修改人Id
        /// </summary>
        [DisplayName("最后修改人Id")]
        [SugarColumn(IsNullable = true, ColumnDescription = "最后修改人Id")]
        public Guid? LastModifyId { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName("最后修改时间")]
        [SugarColumn(IsNullable = true, ColumnDescription = "最后修改时间")]
        public DateTime LastModifedAt { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName("是否删除")]
        [SugarColumn(ColumnDescription = "是否删除")]
        public bool IsDeleted { get; set; }


        #endregion 
    }
}
