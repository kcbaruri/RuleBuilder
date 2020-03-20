//This function removes column from the rule row of a table.
function deleteRuleParameter(targetControlId) {
    var currentControlId = "#" + targetControlId.id;
    var closestRow = $(currentControlId).closest('tr');
    var desiredColumnIndex = $('#hiddenField').val();
    closestRow.find('td').eq(desiredColumnIndex).remove();
}

function deleteRow(buttonControl) {
   
    if (confirm("Do you want to delete this record.")) {
        var nearestTable = $('#' + buttonControl.id).closest('table').attr('id');
        var nearestDiv = $('#' + nearestTable).parent().closest('div').attr("id");
        $('#' + nearestDiv).closest("div").prev().remove();
        $('#' + nearestDiv).remove();

        if ($('#' + nearestDiv.substr(0, 6)).find(".item").size() <= 1) {
            $('#' + nearestDiv.substr(0, 6)).find(".boolean").hide("fast");
        }
    }
}

//Deleting the rule block.
function deleteRuleInnerBlock() {
    var currentControlId = $('#hiddenFieldForClosestCi').val();;
    var closestDiv = $('#'+currentControlId).closest('div');
    closestDiv.remove();
}


//Save the column index which is currently clicked.
function saveCurrentlyFocusedColumnIndex(targetControl) {

    var currentControlId = "#" + targetControl.id;
    var columnIndex = $(currentControlId).closest('td').index();
    $('#hiddenField').val(columnIndex);

    var closestCi = $(currentControlId).closest('div');
    $('#hiddenFieldForClosestCi').val(closestCi.attr('id'));
}



