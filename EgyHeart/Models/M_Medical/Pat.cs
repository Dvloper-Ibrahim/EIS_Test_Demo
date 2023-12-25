using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EgyHeart.Models.M_Medical;

[Table("PAT")]
public partial class Pat
{
    [Column("BRANCH_ID")]
    public double? BranchId { get; set; }

    [Key]
    [Column("PAT_ID")]
    public int PatId { get; set; }

    [Column("PAT_NAME")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PatName { get; set; }

    [Column("PERSONAL_ID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PersonalId { get; set; }

    [Column("NEW_OLD")]
    public double? NewOld { get; set; }

    [Column("PAT_ADDRESS")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PatAddress { get; set; }

    [Column("PAT_TEL")]
    [StringLength(14)]
    [Unicode(false)]
    public string? PatTel { get; set; }

    [Column("PAT_MOBILE")]
    [StringLength(14)]
    [Unicode(false)]
    public string? PatMobile { get; set; }

    [Column("BIRTH_DATE", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("PERSON_KIND")]
    public double? PersonKind { get; set; }

    [Column("PAT_DATE", TypeName = "datetime")]
    public DateTime? PatDate { get; set; }

    [Column("USER_CODE")]
    public double? UserCode { get; set; }

    [Column("PAT_REPEAT")]
    public double? PatRepeat { get; set; }

    [Column("REPLCATE")]
    public double? Replcate { get; set; }

    [Column("PAT_AGE_TYPE")]
    public double? PatAgeType { get; set; }

    [Column("PAT_ID_CARD")]
    public long? PatIdCard { get; set; }

    [Column("SHEET_NO")]
    public double? SheetNo { get; set; }

    [Column("YOUNG_DAY")]
    public double? YoungDay { get; set; }

    [Column("YOUNG_MONTH")]
    public double? YoungMonth { get; set; }

    [Column("BR_REPLC")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BrReplc { get; set; }

    [Column("ENTRY_DATE", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("PAT_EMAIL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? PatEmail { get; set; }

    [Column("NATIONALITY_ID")]
    public double? NationalityId { get; set; }

    [Column("RELIGION_ID")]
    public double? ReligionId { get; set; }

    [Column("PAT_ID_SER")]
    public long? PatIdSer { get; set; }

    [Column("ID_TYPE")]
    public double? IdType { get; set; }

    [Column("DOC_COMP_NR")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DocCompNr { get; set; }

    [Column("DOC_PAT_NR")]
    [StringLength(6)]
    [Unicode(false)]
    public string? DocPatNr { get; set; }

    [Column("P_DEP")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PDep { get; set; }

    [Column("P_CRT")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PCrt { get; set; }

    [Column("P_GROUP")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PGroup { get; set; }

    [Column("FINANCE_ID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FinanceId { get; set; }

    [Column("PAT_PASSWORD")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PatPassword { get; set; }
}
