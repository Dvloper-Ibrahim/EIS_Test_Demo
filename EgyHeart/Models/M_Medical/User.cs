using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EgyHeart.Models.M_Medical;

[Table("USERS")]
public partial class User
{
    [Key]
    [Column("USER_CODE")]
    public double UserCode { get; set; }

    [Column("USER_NAME")]
    [StringLength(70)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("USER_CONTROLER")]
    public double? UserControler { get; set; }

    [Column("PASS_WORD")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PassWord { get; set; }

    [Column("PASS_CONFIRM")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PassConfirm { get; set; }

    [Column("USER_G_ID")]
    public double? UserGId { get; set; }

    [Column("USER_LANG")]
    public double? UserLang { get; set; }

    [Column("SIDE_ID")]
    public double? SideId { get; set; }

    [Column("BRANCH_ID")]
    public double? BranchId { get; set; }

    [Column("USER_TYPE")]
    public double? UserType { get; set; }

    [Column("F_YEAR")]
    public double? FYear { get; set; }

    [Column("DISCOUNT_ID")]
    public double? DiscountId { get; set; }
}
