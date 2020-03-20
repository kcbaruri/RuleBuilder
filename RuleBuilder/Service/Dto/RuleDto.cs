namespace Service.Dto
{
    public interface ISaveRuleDto
    {
        int? Id { get; set; }
        string Name { get; set; }
        string Operator { get; set; }
        string Connector { get; set; }
        string RuleDetails { get; set; }
        bool IsPercentage { get; set; }
    }
}