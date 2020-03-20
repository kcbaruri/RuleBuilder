using Service.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RuleBuilder.Models
{
    public class SaveRuleViewModel : ISaveRuleDto
    {
        [DisplayName("ID")]
        public int? Id { get; set; }

        [DisplayName("Rule Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} can be maximum of {1} characters.")]
        public string Name { get; set; }

        public string RuleCagoryId { get; set; }

        [DisplayName("Rule Category")]
        public string RuleCagory { get; set; }

        [Required(ErrorMessage = "Please select parameter")]
        [DisplayName("Parameter Id")]
        public int ParameterId { get; set; }

        [DisplayName("Operator")]
        public string Operator { get; set; }

        [DisplayName("Operation")]
        public string CompareOperation { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public string FromValue { get; set; }
        public string ToValue { get; set; }

        public string ListItem { get; set; }

        [DisplayName("Reference Value")]
        public string ReferenceValue { get; set; }  // This field will hold a value that will be used to that of parameter/rule value etc.

        public string CompareOperand1 { get; set; }

        public string CompareOperand2 { get; set; }
        public string CompareOperand1Group { get; set; }
        public string CompareOperand2Group { get; set; }

        public string FixOrPercentage { get; set; }

        public string PercentageAmount { get; set; }

        public string ChargeOperation { get; set; }

        [DisplayName("Charge")]
        public string Charge { get; set; }

        [DisplayName("Connector")]
        public string Connector { get; set; }

        public string ChargeOperand1 { get; set; }

        public string ChargeOperand2 { get; set; }
        public string ChargeOperand1Group { get; set; }

        public string ChargeOperand2Group { get; set; }

        public string RuleDetails { get; set; }

        public bool IsListItemChecked { get; set; }

        [DisplayName("Parameter Group")]
        public int ParameterGroupId { get; set; }

        public List<string> ParameterValueList { get; set; }

        public DateTime Added { get; set; }

        public bool IsPercentage { get; set; }
        public List<SaveRuleViewModel> List { get; set; }
    }
}