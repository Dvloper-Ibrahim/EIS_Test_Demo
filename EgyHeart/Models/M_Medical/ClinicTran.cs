﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EgyHeart.Models.M_Medical;

[PrimaryKey("MasterId", "CheckId", "ExYear")]
[Table("CLINIC_TRANS")]
public partial class ClinicTran
{
    [Key]
    [Column("MASTER_ID")]
    public double MasterId { get; set; }

    [Key]
    [Column("CHECK_ID")]
    public double CheckId { get; set; }

    [Column("CLINIC_ID")]
    public double? ClinicId { get; set; }

    [Column("EX_DATE", TypeName = "datetime")]
    public DateTime? ExDate { get; set; }

    [Column("EX_DAY")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ExDay { get; set; }

    [Column("S_CLINIC_ID")]
    public double? SClinicId { get; set; }

    [Column("SERV_ID")]
    public double? ServId { get; set; }

    [Column("EX_PERIOD")]
    public double? ExPeriod { get; set; }

    [Column("ENTRY_STATUS")]
    public double? EntryStatus { get; set; }

    [Column("VALUE_SERVICE", TypeName = "decimal(9, 2)")]
    public decimal? ValueService { get; set; }

    [Column("PAT_EXTERNAL")]
    public double? PatExternal { get; set; }

    [Column("DR_CODE")]
    public double? DrCode { get; set; }

    [Column("SPECIFIC_CODE")]
    public double? SpecificCode { get; set; }

    [Column("RECEPT_EMP_CODE")]
    public double? ReceptEmpCode { get; set; }

    [Column("DR_CODE_CONERTER")]
    public double? DrCodeConerter { get; set; }

    [Column("COMP_ID")]
    public double? CompId { get; set; }

    [Column("PATIENT_VALUE", TypeName = "decimal(9, 2)")]
    public decimal? PatientValue { get; set; }

    [Column("CHECK_ID_CANCEL")]
    public double? CheckIdCancel { get; set; }

    [Column("EX_INVOICE_NO")]
    public double? ExInvoiceNo { get; set; }

    [Column("PAT_STATUS")]
    public double? PatStatus { get; set; }

    [Key]
    [Column("EX_YEAR")]
    public double ExYear { get; set; }

    [Column("EX_MONTH")]
    public double? ExMonth { get; set; }

    [Column("PAT_EMERG")]
    public double? PatEmerg { get; set; }

    [Column("QTY")]
    public double? Qty { get; set; }

    [Column("PAT_TIME", TypeName = "datetime")]
    public DateTime? PatTime { get; set; }

    [Column("FLAG")]
    public double? Flag { get; set; }

    [Column("PAT_SER")]
    public double? PatSer { get; set; }

    [Column("PAT_PHAR_NAME")]
    [StringLength(75)]
    [Unicode(false)]
    public string? PatPharName { get; set; }

    [Column("CREATE_DATE", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("PAT_PERC", TypeName = "decimal(5, 2)")]
    public decimal? PatPerc { get; set; }

    [Column("MODIFY_DATE_TIME", TypeName = "datetime")]
    public DateTime? ModifyDateTime { get; set; }

    [Column("DR_VAL", TypeName = "decimal(9, 2)")]
    public decimal? DrVal { get; set; }

    [Column("HO_VAL", TypeName = "decimal(9, 2)")]
    public decimal? HoVal { get; set; }

    [Column("DR_VAL_PAT", TypeName = "decimal(9, 2)")]
    public decimal? DrValPat { get; set; }

    [Column("HO_VAL_PAT", TypeName = "decimal(9, 2)")]
    public decimal? HoValPat { get; set; }

    [Column("BRANCH_ID")]
    public double? BranchId { get; set; }

    [Column("COMP_VALUE", TypeName = "decimal(9, 2)")]
    public decimal? CompValue { get; set; }

    [Column("WAIT_STATUS")]
    public double? WaitStatus { get; set; }

    [Column("WAIT_RESON")]
    public double? WaitReson { get; set; }

    [Column("VIST_CONFIRM")]
    public double? VistConfirm { get; set; }

    [Column("WAIT_DATE", TypeName = "datetime")]
    public DateTime? WaitDate { get; set; }

    [Column("WAIT_CONV")]
    public double? WaitConv { get; set; }

    [Column("WAIT_OTHER")]
    public double? WaitOther { get; set; }

    [Column("PAT_ID")]
    public double? PatId { get; set; }

    [Column("MAIN_INV_NO")]
    public long? MainInvNo { get; set; }

    [Column("USER_CODE_CREATE")]
    public double? UserCodeCreate { get; set; }

    [Column("USER_CODE_MODIFY")]
    public double? UserCodeModify { get; set; }

    [Column("CONV_DATE", TypeName = "datetime")]
    public DateTime? ConvDate { get; set; }

    [Column("STOCK_CODE")]
    public double? StockCode { get; set; }

    [Column("SUB_CODE")]
    public double? SubCode { get; set; }

    [Column("MAIN_CODE")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MainCode { get; set; }

    [Column("ITEM_MASTER")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ItemMaster { get; set; }

    [Column("TRANS_TYPE")]
    public double? TransType { get; set; }

    [Column("SERIAL")]
    public double? Serial { get; set; }

    [Column("SER_SYS")]
    public double? SerSys { get; set; }

    [Column("REPLCATE")]
    public double? Replcate { get; set; }

    [Column("RESERVE_FLAG")]
    public double? ReserveFlag { get; set; }

    [Column("UNIT_PRICE", TypeName = "decimal(9, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column("PAT_AD_DATE", TypeName = "datetime")]
    public DateTime? PatAdDate { get; set; }

    [Column("DR_SEND")]
    public double? DrSend { get; set; }

    [Column("EXCHANGE_TYPE")]
    public double? ExchangeType { get; set; }

    [Column("DOC_NO")]
    public double? DocNo { get; set; }

    [Column("MACHINE")]
    public double? Machine { get; set; }

    [Column("MCH_HOURS", TypeName = "decimal(6, 2)")]
    public decimal? MchHours { get; set; }

    [Column("ITM_SERV_FLAG")]
    public double? ItmServFlag { get; set; }

    [Column("BENEFICIARY_NAME")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BeneficiaryName { get; set; }

    [Column("KINSHIP")]
    public double? Kinship { get; set; }

    [Column("DR_ALALYSIS")]
    public double? DrAlalysis { get; set; }

    [Column("NERSE1")]
    public double? Nerse1 { get; set; }

    [Column("NERSE2")]
    public double? Nerse2 { get; set; }

    [Column("DATE_ANALYSIS", TypeName = "datetime")]
    public DateTime? DateAnalysis { get; set; }

    [Column("FLAG1")]
    public double? Flag1 { get; set; }

    [Column("SERIVICE_WITH_ITEMS")]
    public double? SeriviceWithItems { get; set; }

    [Column("DR_SEND_VAL", TypeName = "decimal(11, 2)")]
    public decimal? DrSendVal { get; set; }

    [Column("FLAG_DR_DISC")]
    public double? FlagDrDisc { get; set; }

    [Column("COST_PRICE", TypeName = "decimal(12, 2)")]
    public decimal? CostPrice { get; set; }

    [Column("DISCOUNT_VAL", TypeName = "decimal(11, 2)")]
    public decimal? DiscountVal { get; set; }

    [Column("PIPE_FLAG")]
    public double? PipeFlag { get; set; }

    [Column("POST_ID")]
    public double? PostId { get; set; }

    [Column("ITM_BARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ItmBarcode { get; set; }

    [Column("ENTRY_DATE", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("DEAL")]
    public double? Deal { get; set; }

    [Column("APPROVAL_PERIOD")]
    public double? ApprovalPeriod { get; set; }

    [Column("APPROVAL_DATE", TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [Column("USER_APPROVAL")]
    public double? UserApproval { get; set; }

    [Column("ATTENDANCE_SER")]
    public double? AttendanceSer { get; set; }

    [Column("PROCEDURE_ID")]
    public double? ProcedureId { get; set; }

    [Column("BR_REPLC")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BrReplc { get; set; }

    [Column("SEND_FR")]
    public double? SendFr { get; set; }

    [Column("SEND_TO")]
    public double? SendTo { get; set; }

    [Column("ITEM_VISIBLE")]
    public double? ItemVisible { get; set; }

    [Column("INCOMING_FR")]
    public double? IncomingFr { get; set; }

    [Column("EXTRA_VAL", TypeName = "decimal(9, 2)")]
    public decimal? ExtraVal { get; set; }

    [Column("COMP_ID_DTL")]
    public double? CompIdDtl { get; set; }

    [Column("MAIN_INV_NO_ALL")]
    public int? MainInvNoAll { get; set; }

    [Column("MAIN_INV_NO_TAX")]
    public int? MainInvNoTax { get; set; }

    [Column("MAIN_INV_TOT")]
    public int? MainInvTot { get; set; }

    [Column("SALSE_PRICE", TypeName = "decimal(12, 3)")]
    public decimal? SalsePrice { get; set; }

    [Column("DR_DUE_VAL", TypeName = "decimal(9, 2)")]
    public decimal? DrDueVal { get; set; }

    [Column("PAT_ID_SECTION")]
    public double? PatIdSection { get; set; }

    [Column("USER_SAFE")]
    public double? UserSafe { get; set; }

    [Column("CSH_ORD_NUM")]
    public double? CshOrdNum { get; set; }

    [Column("SESSION_NO")]
    public double? SessionNo { get; set; }

    [Column("KNOW_US_FR")]
    public short? KnowUsFr { get; set; }

    [Column("EXTRA_VAL2", TypeName = "decimal(9, 2)")]
    public decimal? ExtraVal2 { get; set; }

    [Column("SUP_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string? SupCode { get; set; }
}
