$(function () {
    //Hide Spinner
    $("#spinner").hide();

    //    Sort By Names
    $("#names").autocomplete({
        source: "Controllers/Handlers/NameSortHandler.ashx",
        select: function(event, ui) {
            var searchQuery = ui.item.value;

            $("#tabBody").load("/Employees/SortByNames?query=" + searchQuery);
        }
    });


    // Sort By DateRange
    $('input[name="daterange"]').daterangepicker();

    $("#datarange").on("apply.daterangepicker",
        function(event, picker) {
            var start = picker.startDate.format("DD-MM-YYYY");
            var end = picker.endDate.format("DD-MM-YYYY");

            $("#tabBody").load("/Employees/SortByDates?from=" + start + "&to=" + end);
        });


    //Sort By Grade
    $("#grade").selectmenu({ width: "auto" });

    $("#grade").on("selectmenuchange",
        function() {
            var grade = $(this).val();

            $("#tabBody").load("/Employees/SortByGrades?grade=" + grade);
        });


    //Sort By Department
    $("#department").selectmenu({ width: "auto" });

    $("#department").on("selectmenuchange",
        function() {
            var department = $(this).val();

            $("#tabBody").load("/Employees/SortByDepartments?department=" + department);
        });


    //Sort By Manager
    $("#manager").selectmenu({ width: "auto" });

    $("#manager").on("selectmenuchange",
        function() {
            var manager = $(this).val();
            manager = manager.split(" ");

            $("#tabBody").load("/Employees/SortByManager?firstName=" + manager[0] + "&lastname=" + manager[1]);
        });
});


$(document).ajaxError(function(event, request, settings) {
    alert("Something went wrong!");
});

// Handle Spinner
$(document).ajaxSend(function() {
    $("#spinner").show();
});

$(document).ajaxStop(function () {
    $("#spinner").hide();
});
