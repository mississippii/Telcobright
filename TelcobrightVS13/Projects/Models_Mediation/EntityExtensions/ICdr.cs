﻿using System;

namespace MediationModel
{
    public interface ICdr
    {
         int SwitchId { get; set; }
         long IdCall { get; set; }
         long SequenceNumber { get; set; }
         string FileName { get; set; }
         int ServiceGroup { get; set; }
         string IncomingRoute { get; set; }
         string OriginatingIP { get; set; }
         Nullable<int> OPC { get; set; }
         Nullable<int> OriginatingCIC { get; set; }
         string OriginatingCalledNumber { get; set; }
         string TerminatingCalledNumber { get; set; }
         string OriginatingCallingNumber { get; set; }
         string TerminatingCallingNumber { get; set; }
         Nullable<int> PrePaid { get; set; }
         decimal DurationSec { get; set; }
         DateTime EndTime { get; set; }
         Nullable<DateTime> ConnectTime { get; set; }
         Nullable<DateTime> AnswerTime { get; set; }
         Nullable<int> ChargingStatus { get; set; }
         Nullable<Single> PDD { get; set; }
         string CountryCode { get; set; }
         string AreaCodeOrLata { get; set; }
         Nullable<int> ReleaseDirection { get; set; }
         Nullable<int> ReleaseCauseSystem { get; set; }
         Nullable<int> ReleaseCauseEgress { get; set; }
         string OutgoingRoute { get; set; }
         string TerminatingIP { get; set; }
         Nullable<int> DPC { get; set; }
         Nullable<int> TerminatingCIC { get; set; }
         DateTime StartTime { get; set; }
         Nullable<int> InPartnerId { get; set; }
        Nullable<decimal> CustomerRate { get; set; }
        Nullable<int> OutPartnerId { get; set; }
         Nullable<decimal> SupplierRate { get; set; }
         string MatchedPrefixY { get; set; }
         Nullable<decimal> UsdRateY { get; set; }
         string MatchedPrefixCustomer { get; set; }
         string MatchedPrefixSupplier { get; set; }
         Nullable<decimal> InPartnerCost { get; set; }
         Nullable<decimal> OutPartnerCost { get; set; }
         Nullable<decimal> CostAnsIn { get; set; }
         Nullable<decimal> CostIcxIn { get; set; }
         Nullable<decimal> Tax1 { get; set; }
         Nullable<decimal> IgwRevenueIn { get; set; }
         Nullable<decimal> RevenueAnsOut { get; set; }
         Nullable<decimal> RevenueIgwOut { get; set; }
         Nullable<decimal> RevenueIcxOut { get; set; }
         Nullable<decimal> Tax2 { get; set; }
         Nullable<decimal> XAmount { get; set; }
         Nullable<decimal> YAmount { get; set; }
         string AnsPrefixOrig { get; set; }
         Nullable<int> AnsIdOrig { get; set; }
         string AnsPrefixTerm { get; set; }
         Nullable<int> AnsIdTerm { get; set; }
         Nullable<int> ValidFlag { get; set; }
         Nullable<int> PartialFlag { get; set; }
         Nullable<int> ReleaseCauseIngress { get; set; }
         Nullable<int> InRoamingOpId { get; set; }
         Nullable<int> OutRoamingOpId { get; set; }
         Nullable<int> CalledPartyNOA { get; set; }
         Nullable<int> CallingPartyNOA { get; set; }
         string AdditionalSystemCodes { get; set; }
         string AdditionalPartyNumber { get; set; }
         string ResellerIds { get; set; }
         Nullable<decimal> ZAmount { get; set; }
         string PreviousRoutes { get; set; }
         Nullable<int> E1Id { get; set; }
         string MediaIp1 { get; set; }
         string MediaIp2 { get; set; }
         string MediaIp3 { get; set; }
         string MediaIp4 { get; set; }
         Nullable<Single> CallReleaseDuration { get; set; }
         Nullable<int> E1IdOut { get; set; }
        string InTrunkAdditionalInfo { get; set; }
        string OutTrunkAdditionalInfo { get; set; }
         string InMgwId { get; set; }
         string OutMgwId { get; set; }
         Nullable<int> MediationComplete { get; set; }
         string Codec { get; set; }
         Nullable<int> ConnectedNumberType { get; set; }
         string RedirectingNumber { get; set; }
         Nullable<int> CallForwardOrRoamingType { get; set; }
         Nullable<DateTime> OtherDate { get; set; }
        decimal? SummaryMetaTotal { get; set; }
        Nullable<decimal> TransactionMetaTotal { get; set; }
         Nullable<decimal> ChargeableMetaTotal { get; set; }
         string ErrorCode { get; set; }
         Nullable<int> NERSuccess { get; set; }
         Nullable<decimal> RoundedDuration { get; set; }
         Nullable<decimal> PartialDuration { get; set; }
         Nullable<DateTime> PartialAnswerTime { get; set; }
         Nullable<DateTime> PartialEndTime { get; set; }
         Nullable<long> FinalRecord { get; set; }
         Nullable<decimal> Duration1 { get; set; }
         Nullable<decimal> Duration2 { get; set; }
         Nullable<decimal> Duration3 { get; set; }
         Nullable<decimal> Duration4 { get; set; }
         Nullable<int> PreviousPeriodCdr { get; set; }
         string UniqueBillId { get; set; }
         string AdditionalMetaData { get; set; }
         Nullable<int> Category { get; set; }
         Nullable<int> SubCategory { get; set; }
         Nullable<long> ChangedByJobId { get; set; }
         DateTime SignalingStartTime { get; set; }
    }
}
