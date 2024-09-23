namespace RepoCentral.Application.DTOs;

public class RepoDTO
{
    public int Id { get; set; }
    public int AgreementID { get; set; }
    public int Version { get; set; }
    public int RepoType { get; set; }
    public int RepoID { get; set; }
    public DateTime AgreementDate { get; set; }
    public string ParentRepoUniqueID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime MaturityDate { get; set; }
    public string PortfolioStrategyID { get; set; }
    public string PortfolioGroupID { get; set; }
    public string CustodianAcctID { get; set; }
    public string BrokerBeneficiaryAccount { get; set; }
    public string BrokerID { get; set; }
    public string PortfolioID { get; set; }
    public int CurrencyID { get; set; }
    public DateTime InitialRefIndexSettingDate { get; set; }
    public float InitialRefIndexRate { get; set; }
    public int RefIndex { get; set; }
    public int RateType { get; set; }
    public int CounterPartyID { get; set; }
    public int RoundingConvention { get; set; }
    public int SWIFTAction { get; set; }
    public int SettleType { get; set; }
    public bool IsApproved { get; set; }
    public string ApprovalUser { get; set; }
    public int RepoStatusID { get; set; }
    public int PSETID { get; set; }
    public string BrokerClearingID { get; set; }
    public int RepoVersion { get; set; }
    public string UpdateUser { get; set; }
    public string Notes { get; set; }
}
