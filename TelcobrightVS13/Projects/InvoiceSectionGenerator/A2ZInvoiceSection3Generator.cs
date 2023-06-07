﻿using System;
using TelcobrightMediation;
using System.ComponentModel.Composition;
using MediationModel;
using TelcobrightMediation.Accounting;

namespace InvoiceSectionGenerator
{
    [Export("InvoiceSectionGenerator", typeof(IInvoiceSectionGenerator))]
    public class A2ZInvoiceSection3Generator : AbstractInvoiceSectionGenerator
    {
        public override string RuleName => this.GetType().Name;
        public override InvoiceSection GetInvoiceSection(InvoiceSectionGeneratorData invoiceSectionGeneratorData)
        {
            string sql = $@"select tup_starttime as Date,tup_customerrate as Rate, TotalCalls,TotalMinutes, Amount
                            from
                            (select tup_starttime,tup_customerrate,
                            sum(successfulcalls)	as TotalCalls,                                  
                            sum(duration1)/60  as TotalMinutes,                                   
                            sum(customercost)  as Amount                                          
                            from {invoiceSectionGeneratorData.CdrOrSummaryTableName}                          
                            where {invoiceSectionGeneratorData.GetWhereClauseForDateCustomerId("tup_inPartnerId")}
                            and successfulcalls > 0 
                            group by tup_starttime,tup_customerrate) x;";
            return base.GetInvoiceSection<InvoiceSectionDataRowForA2ZVoice>(invoiceSectionGeneratorData, sql);
        }
    }
}
