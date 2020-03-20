function renameRuleContainer() {
    var actionItem = 'ai' + $("#action_list > div").length; // ai = action item
    $('#ai_new').attr('id', actionItem);
   
    if ($('#action_list').html().includes('rule_connector')) {
        var ruleConnector = 'rule_connector' + actionItem.replace('ai', 'con');
        $('#rule_connector').attr('id', ruleConnector);
        $('#connectorList_newRow').attr('id', 'connectorList' + actionItem);
    }
    var innerCounter = $('#' + actionItem + ' .condition_container').length;

    if (innerCounter == 0) {
        innerCounter = 1;
    }
    $('#cc_new').attr('id', actionItem + 'cc' + innerCounter); // cc = conditioner container.
    $('#ac_new').attr('id', actionItem + 'ac' + innerCounter); // ac = action container which is rule output of a block.
}

function renameConditionBlockControls() {
    var parentId = $("#tblInner_new").parent().attr('id');
    var columnCount = 1;

    $("#tblInner_new").attr("id", parentId + "tbl");
    $("#conditional_operand_type_list_newRow").attr("id", parentId + "_condition_operand_type_list_colindex_" + (columnCount++));
    $("#rbOperatorListCol2_newRow").attr("id", parentId + "_condition_operand_comperator_list_colindex_" + (columnCount++));
    $("#drp_inner_connector").attr("id", parentId + "_condition_inner_connector_list_colindex_" + (columnCount++));
    
    
    $("#btnAddMoreCellsCol13_newRow").attr("id", parentId + "_condition_button_add_more_colindex_" + (columnCount++));
    $("#btnAddLeftBracketCellsCol13_newRow").attr("id", parentId + "_condition_button_add_left_parenthesis_colindex_" + (columnCount++));
    $("#btnAddRightBracketCellsCol13_newRow").attr("id", parentId + "_condition_button_add_right_parenthesis_colindex_" + (columnCount++));
    $("#btnDeleteInnerCellsCol13_newRow").attr("id", parentId + "_condition_button_delete_inner_cell_colindex_" + (columnCount++));
    $("#btnDeleteRowCol3_newRow").attr("id", parentId + "_condition_button_delete_row_colindex_" + (columnCount++));
}

function renameRuleOutputBlockControls() {
    var parentId = $("#tblChargeInner_new").parent().attr('id');
    var columnCount = 1;

    $("#tblChargeInner_new").attr("id", parentId + "tbl");
    
    $("#rule_output_type_list_newRow").attr("id", parentId + "_action_rule_output_type_list_colindex_" + (columnCount++));

    $("#robValueTypeListCol1_newRow").attr("id", parentId + "_action_operand_type_list_colindex_" + (columnCount++));

    $("#btnAddRuleOutput_newColumn").attr("id", parentId + "_action_button_add_more_parameter_colindex_" + (columnCount++));

    $("#btnAddLeftBracketCellsCol13_newRow").attr("id", parentId + "_action_button_add_left_parenthesis_colindex_" + (columnCount++));
    $("#btnAddRightBracketCellsCol13_newRow").attr("id", parentId + "_action_button_add_right_parenthesis_colindex_" + (columnCount++));

    $("#btnDeleteRuleOutput_newColumn").attr("id", parentId + "_action_button_delete_rule_output_row_colindex_" + (columnCount++));
    $("#btnDeleteRuleParameter_newColumn").attr("id", parentId + "_action_button_delete_rule_output_parameter_colindex_" + (columnCount++));
}

//This function is used to rename controls added dynamically when any value is selected from the drop down list.
function renameRuleOperandOnValueSelection(selectedValue, parentId, columnCount) {
    if (selectedValue == "VLU") {
        $("#rbTxtReferenceValueCol6_newRow").attr("id", parentId + "_condition_operand_txt_reference_value_colindex_" + (columnCount++));
    }
    else if (selectedValue == "PMR" || selectedValue == "LDAY") {
        $("#ruleParameterListCol12_newRow").attr("id", parentId + "_condition_operand_parameter_list_colindex_" + (columnCount++));
    }
    else if (selectedValue == "AVG" || selectedValue == "MAX" || selectedValue == "MIN" || selectedValue == "SUM") {
        $("#mathOperandTypeList00_newRow").attr("id", parentId + "_condition_operand_math_operand_type_list_colindex_" + (columnCount++));
    }
    else if (selectedValue == "FLOOR" || selectedValue == "CEILING" || selectedValue == "MATHMATICAL" || selectedValue == "DAY") {
        $("#conditional_operand_type_list_newRow").attr("id", parentId + "_condition_operand_math_operand_type_list_colindex_" + (columnCount++));
    }
    else if (selectedValue == "DATE") {
        var dateFieldId = parentId + "_condition_operand_date_value_colindex_" + (columnCount++);
        $("#condition_control_date").attr("id", dateFieldId);

        $("#" + dateFieldId).datepicker({

            changeMonth: true,
            changeYear: true,
            dateFormat: 'yy-mm-dd'
        });
    }
}

//Add left/right bracket in a rule row.
function addOpenCloseParenthesis(number, targetControl) {
    var currentControlId = "#" + targetControl.id;

    var currentRow = $(currentControlId).closest('tr');

    var targetColumn = $('#hiddenField').val();

    var columnsToAdd = '';

    if (number == 1) {
        columnsToAdd += '<td width = "10" style ="display:inline-block">';
        columnsToAdd += '<div id = "start_parenthesis" style="font-size:xx-large; font-weight: bold;" onclick = "saveCurrentlyFocusedColumnIndex(this)">(</div>';
        columnsToAdd += '</td>';
        columnsToAdd = columnsToAdd.replace(/&quot;/g, " ");
        currentRow.find("td").eq(targetColumn).before(columnsToAdd);
    }
    else {
        columnsToAdd += '<td width = "10" style ="display:inline-block">';
        columnsToAdd += '<div id = "end_parenthesis" style="font-size:xx-large; font-weight: bold;" onclick = "saveCurrentlyFocusedColumnIndex(this)">)</div>';
        columnsToAdd += '</td>';

        columnsToAdd = columnsToAdd.replace(/&quot;/g, " ");
        currentRow.find("td").eq(targetColumn).after(columnsToAdd);
    }
}