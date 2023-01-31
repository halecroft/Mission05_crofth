$("#btnCalculate").click(function () {
    //Calculate individual percentages and add them together
    var gradePercent = Number($("#inptAssignments").val()) * 0.5;
    gradePercent += Number($("#inptGroupProject").val()) * 0.1;
    gradePercent += Number($("#inptQuizzes").val()) * 0.1;
    gradePercent += Number($("#inptMidtermExam").val()) * 0.1;
    gradePercent += Number($("#inptFinalExam").val()) * 0.1;
    gradePercent += Number($("#inptINTEX").val()) * 0.1;

    //Determine the correct letter grade
    var letterGrade = ""
    if (gradePercent >= 94) {
        letterGrade = "A"
    } else if (gradePercent >= 90) {
        letterGrade = "A-"
    } else if (gradePercent >= 87) {
        letterGrade = "B+"
    } else if (gradePercent >= 84) {
        letterGrade = "B"
    } else if (gradePercent >= 80) {
        letterGrade = "B-"
    } else if (gradePercent >= 77) {
        letterGrade = "C+"
    } else if (gradePercent >= 74) {
        letterGrade = "C"
    } else if (gradePercent >= 70) {
        letterGrade = "C-"
    } else if (gradePercent >= 67) {
        letterGrade = "D+"
    } else if (gradePercent >= 64) {
        letterGrade = "D"
    } else if (gradePercent >= 60) {
        letterGrade = "D"
    } else {
        letterGrade = "E"
    }

    //Display the calculated percent and letter grade
    $("#calculatedGrade").text("Calculated Grade: " + gradePercent + "%, which is a " + letterGrade)
})