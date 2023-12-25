using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EgyHeart.Models.M_Medical;

[Index("NormalizedEmail", Name = "EmailIndex")]
public partial class AspNetUser
{
    [Key]
    public string Id { get; set; } = null!;

    [StringLength(256)]
    public string? UserName { get; set; }

    [StringLength(256)]
    public string? NormalizedUserName { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [StringLength(256)]
    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

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
