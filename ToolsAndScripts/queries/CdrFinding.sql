SELECT StartTime, AnswerTime, EndTime,
OriginatingCalledNumber as CalledNumber,OriginatingCallingNumber as CallingNumber,
duration1, InPartnerId,OutPartnerId, cr.PartnerName as 'In Partner Name', outP.PartnerName as 'Out Partner Name'
FROM cdr c
left join partner cr on 
c.inpartnerid= cr.idPartner
left join partner outP on 
c.OutPartnerId= outP.idPartner
where starttime >='2022-12-02' and starttime <'2022-12-03'
and ServiceGroup=1
limit 0,1;
