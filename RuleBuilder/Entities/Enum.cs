using System.ComponentModel;

namespace Common
{
    public enum RuleOutputTypes
    {
        [Description("Numeric")]
        NUMERIC,
        [Description("Text")]
        TEXT,
        [Description("Date")]
        DATE
    }

    public enum InnerConnectorList
    {
        [Description("AND")]
        AND,
        [Description("OR")]
        OR
    }

    public enum ConfigVariableTypes
    {
        [Description("1")]
        INTEGER = 1,
        [Description("2")]
        DOUBLE = 2,
        [Description("3")]
        STRING = 3,
        [Description("4")]
        DATE = 4
    }

    public enum CommunicationModes
    {
        [Description("Active")]
        ACTIVE,
        [Description("Test")]
        TEST
    }

    public enum RuleElseIfList
    {
        [Description("IF")]
        IF,
        [Description("ELSE IF")]
        ELSEIF,
        [Description("ELSE")]
        ELSE
    }


    // This is used to populate the list when a mathematical operation is selected and operand is only numeric. Like - Average is selected.
    public enum MathOperandTypeList
    {
        [Description("Parameter")]
        PMR = 1,
        [Description("Value")]
        VLU = 2
    }

    public enum RuleComperatorList
    {
        [Description("Equals")]
        EQ = 1,
        [Description("Does not equal")]
        DEQ = 2,
        [Description("Greater than")]
        GT = 3,
        [Description("Greater than or equal to")]
        GTE = 4,
        [Description("Less than")]
        LT = 5,
        [Description("Less than or equal to")]
        LTE = 6,
        [Description("Between")]
        BTE = 7,
        [Description("Is not between")]
        NBTE = 8,
        [Description("Is in table")]
        INTHETABLE = 9
    }

    public enum MathematicalOperationList
    {
        [Description("+")]
        SUM = 1,
        [Description("-")]
        SUB = 2,
        [Description("*")]
        MUL = 3,
        [Description("/")]
        DIV = 4,
        [Description("Pow")]
        POW = 5
    }


    public enum ChargeOperation
    {
        [Description("Value")]
        VLU = 1,
        [Description("Sum")]
        SUM = 2,
        [Description("Sub")]
        SUB = 3,
        [Description("Mul")]
        MUL = 4,
        [Description("Div")]
        DIV = 5
    }

    public enum ParameterCategoryList
    {
        [Description("1")]
        Duration = 1,
        [Description("2")]
        Fixed = 2,
        [Description("3")]
        List = 3,
        [Description("4")]
        Range = 4,
        [Description("5")]
        Rule = 5,
        [Description("6")]
        Table = 6,
        [Description("7")]
        Default = 7
    }
    public enum ParameterUnit
    {
        [Description("1")]
        Number = 1,
        [Description("2")]
        Meter = 2,
        [Description("3")]
        Date = 3,
        [Description("4")]
        KG = 4,
        [Description("5")]
        String = 5
    }

    public enum SiteType
    {
        [Description("1")]
        Barter = 1,
        [Description("2")]
        Selfbuild = 2,
        [Description("3")]
        Shared = 3
    }
    public enum SiteCategory
    {
        [Description("1")]
        RTP = 1,
        [Description("2")]
        RTT = 2,
        [Description("3")]
        GF = 3,
        [Description("4")]
        GFRT = 4,
        [Description("5")]
        GFTP = 5,
        [Description("6")]
        IBS = 6
    }

    public enum RuleOperandTypeList
    {
        [Description("Parameter")] // It covers summation, subtraction, multiplication, division.
        PMR = 1,
        [Description("Value")] // It refers to value type only.
        VLU = 2,
        [Description("Average")] // This deals with parameter or value 
        AVG = 3,
        [Description("Maximum")] // This deals with parameter or value 
        MAX = 4,
        [Description("Minimum")] // This deals with parameter or value 
        MIN = 5,
        [Description("Summation")] // This deals with parameter or value 
        SUM = 6,
        [Description("Last Day Of")]
        LDAY = 7,
        [Description("Day Func")]
        DAY = 8,
        [Description("Days Func")]
        DAYS = 9,
        [Description("Month Func")]
        MONTH = 10,
        [Description("Year Func")]
        YEAR = 11,
        [Description("Date")]
        DATE = 12,
        [Description("Percentage")]
        PER = 13,
        [Description("Floor Func")]
        FLOOR = 14,
        [Description("Ceiling Func")]
        CEILING = 15,
        [Description("Mathmatical")]
        MATHMATICAL = 16,
        [Description("Lookup")]
        VLOOKUP = 17
    }
}
