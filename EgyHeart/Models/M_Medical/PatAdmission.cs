using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EgyHeart.Models.M_Medical;

[PrimaryKey("MasterId", "ExYear")]
[Table("PAT_ADMISSION")]
public partial class PatAdmission
{
    [Column("BRANCH_ID")]
    public double? BranchId { get; set; }

    [Key]
    [Column("MASTER_ID")]
    public double MasterId { get; set; }

    [Column("PAT_ID")]
    public double? PatId { get; set; }

    [Column("DEAL")]
    public double? Deal { get; set; }

    [Column("PAT_AD_DATE", TypeName = "datetime")]
    public DateTime? PatAdDate { get; set; }

    [Column("COMP_ID")]
    public double? CompId { get; set; }

    [Column("PAT_INTERNAL")]
    public double? PatInternal { get; set; }

    [Column("PAT_EXTERNAL")]
    public double? PatExternal { get; set; }

    [Column("PAT_EMERGENCY")]
    public double? PatEmergency { get; set; }

    [Column("PAT_EXIT")]
    public double? PatExit { get; set; }

    [Column("PAT_DATE_EXIT", TypeName = "datetime")]
    public DateTime? PatDateExit { get; set; }

    [Column("DECISION_SHEET")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DecisionSheet { get; set; }

    [Column("PAT_CARD_ID")]
    public double? PatCardId { get; set; }

    [Column("REPLCATE")]
    public double? Replcate { get; set; }

    [Key]
    [Column("EX_YEAR")]
    public double ExYear { get; set; }

    [Column("PAT_AD_TIME", TypeName = "datetime")]
    public DateTime? PatAdTime { get; set; }

    [Column("MAIN_INV_NO")]
    public int? MainInvNo { get; set; }

    [Column("MAIN_INV_TOT", TypeName = "decimal(9, 2)")]
    public decimal? MainInvTot { get; set; }

    [Column("MAIN_INV_DESC")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MainInvDesc { get; set; }

    [Column("PATIENT_VALUE", TypeName = "decimal(9, 2)")]
    public decimal? PatientValue { get; set; }

    [Column("COMP_VALUE", TypeName = "decimal(9, 2)")]
    public decimal? CompValue { get; set; }

    [Column("DR_CODE")]
    public double? DrCode { get; set; }

    [Column("DR_VAL", TypeName = "decimal(10, 2)")]
    public decimal? DrVal { get; set; }

    [Column("DR_TAX", TypeName = "decimal(10, 2)")]
    public decimal? DrTax { get; set; }

    [Column("EX_MONTH")]
    public double? ExMonth { get; set; }

    [Column("DR_OBTAIN")]
    public double? DrObtain { get; set; }

    [Column("DISCOUNT_VAL", TypeName = "decimal(9, 2)")]
    public decimal? DiscountVal { get; set; }

    [Column("ACC_TRANS_NO")]
    public long? AccTransNo { get; set; }

    [Column("ACC_TRANS_NO2")]
    public long? AccTransNo2 { get; set; }

    [Column("SAFE_DOC_NO")]
    public long? SafeDocNo { get; set; }

    [Column("SAFE_DOC_NO2")]
    public long? SafeDocNo2 { get; set; }

    [Column("ARCH")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Arch { get; set; }

    [Column("ROOM_NO")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RoomNo { get; set; }

    [Column("DAYS_NO")]
    public double? DaysNo { get; set; }

    [Column("DAYS_VALUE", TypeName = "decimal(9, 2)")]
    public decimal? DaysValue { get; set; }

    [Column("FLAG")]
    public double? Flag { get; set; }

    [Column("DUE_VAL", TypeName = "decimal(9, 2)")]
    public decimal? DueVal { get; set; }

    [Column("EXCHANGE_TYPE")]
    public double? ExchangeType { get; set; }

    [Column("NOTE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Note { get; set; }

    [Column("AMANAT", TypeName = "decimal(11, 2)")]
    public decimal? Amanat { get; set; }

    [Column("AMANAT_RET", TypeName = "decimal(11, 2)")]
    public decimal? AmanatRet { get; set; }

    [Column("SAFE_IN_NO1")]
    public double? SafeInNo1 { get; set; }

    [Column("SAFE_IN_NO2")]
    public double? SafeInNo2 { get; set; }

    [Column("AMANAT_RET_PAT", TypeName = "decimal(11, 2)")]
    public decimal? AmanatRetPat { get; set; }

    [Column("KASTARA_TOT", TypeName = "decimal(11, 2)")]
    public decimal? KastaraTot { get; set; }

    [Column("ENAYA_TOT", TypeName = "decimal(11, 2)")]
    public decimal? EnayaTot { get; set; }

    [Column("JOR_KIED_NO1")]
    public double? JorKiedNo1 { get; set; }

    [Column("JOR_KIED_NO2")]
    public double? JorKiedNo2 { get; set; }

    [Column("CASH_NO")]
    public double? CashNo { get; set; }

    [Column("STAMP_VAL", TypeName = "decimal(9, 2)")]
    public decimal? StampVal { get; set; }

    [Column("BR_REPLC")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BrReplc { get; set; }

    [Column("PAT_CLOSE")]
    public double? PatClose { get; set; }

    [Column("PAY_FLAG")]
    public double? PayFlag { get; set; }

    [Column("JOR_KIED_NO3")]
    public double? JorKiedNo3 { get; set; }

    [Column("SAFE_DOC_NO3")]
    public double? SafeDocNo3 { get; set; }

    [Column("EX_YEAR_TO")]
    public double? ExYearTo { get; set; }

    [Column("EX_MONTH_TO")]
    public double? ExMonthTo { get; set; }

    [Column("MAIN_CODE")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MainCode { get; set; }

    [Column("SUB_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string? SubCode { get; set; }

    [Column("BENEFICIARY_NAME")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BeneficiaryName { get; set; }

    [Column("KINSHIP")]
    public double? Kinship { get; set; }

    [Column("INV_TYPE")]
    public double? InvType { get; set; }

    [Column("ENTRY_DATE", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("TRANSF_VAL", TypeName = "decimal(12, 2)")]
    public decimal? TransfVal { get; set; }

    [Column("POST_ID")]
    public double? PostId { get; set; }

    [Column("PAT_RELATIONSHIP")]
    public double? PatRelationship { get; set; }

    [Column("ACC_TRANS_TYPE")]
    public double? AccTransType { get; set; }

    [Column("BRNACH_INITIAL")]
    public double? BrnachInitial { get; set; }

    [Column("DR_SEND")]
    public double? DrSend { get; set; }

    [Column("PAY_PAT_TOT", TypeName = "decimal(11, 2)")]
    public decimal? PayPatTot { get; set; }

    [Column("PAT_ID_SECTION")]
    public double? PatIdSection { get; set; }

    [Column("WINDOW_FLAG")]
    public double? WindowFlag { get; set; }

    [Column("CO_NAME_2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CoName2 { get; set; }

    [Column("SEND_TO")]
    public double? SendTo { get; set; }

    [Column("MAIN_INV_NO_ALL")]
    public int? MainInvNoAll { get; set; }

    [Column("PAT_DATE_OUT", TypeName = "datetime")]
    public DateTime? PatDateOut { get; set; }

    [Column("PROCEDURE_ID")]
    public double? ProcedureId { get; set; }

    [Column("PAT_FR")]
    public double? PatFr { get; set; }

    [Column("USER_CODE_CREATE")]
    public double? UserCodeCreate { get; set; }

    [Column("USER_CODE_MODIFY")]
    public double? UserCodeModify { get; set; }

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

    [Column("SEND_FR")]
    public double? SendFr { get; set; }

    [Column("BOOK_ROOM")]
    public double? BookRoom { get; set; }

    [Column("MAIN_INV_NO_TAX")]
    public int? MainInvNoTax { get; set; }

    [Column("INV_TYPE_TAX")]
    public double? InvTypeTax { get; set; }

    [Column("SEND_TRANSFIR")]
    public double? SendTransfir { get; set; }

    [Column("M_CODE")]
    public double? MCode { get; set; }

    [Column("M_CODE_DTL")]
    public double? MCodeDtl { get; set; }

    [Column("OPERATION_CODE")]
    public double? OperationCode { get; set; }

    [Column("OPERATION_TYPE")]
    public double? OperationType { get; set; }

    [Column("EXTRA_VAL", TypeName = "decimal(9, 2)")]
    public decimal? ExtraVal { get; set; }

    [Column("COMP_ID_DTL")]
    public double? CompIdDtl { get; set; }

    [Column("UUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Uuid { get; set; }

    [Column("SUBMITID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Submitid { get; set; }

    [Column("E_INV_STS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EInvSts { get; set; }

    [Column("EINV_DATE", TypeName = "datetime")]
    public DateTime? EinvDate { get; set; }

    [Column("E_INV_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EInvId { get; set; }

    [Column("EINV_ERR")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EinvErr { get; set; }

    [Column("TAX_FLAG")]
    public double? TaxFlag { get; set; }

    [Column("TAX_DATE", TypeName = "datetime")]
    public DateTime? TaxDate { get; set; }

    [Column("PREPAID", TypeName = "decimal(12, 2)")]
    public decimal? Prepaid { get; set; }

    [Column("SESSION_NO")]
    public double? SessionNo { get; set; }

    [Column("KNOW_US_FR")]
    public short? KnowUsFr { get; set; }

    [Column("EXTRA_VAL2", TypeName = "decimal(9, 2)")]
    public decimal? ExtraVal2 { get; set; }
}
