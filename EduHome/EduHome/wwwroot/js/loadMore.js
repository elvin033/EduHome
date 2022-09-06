
let skip = 6;
let coursesCount = $("#CoursesCount").val();
$(document).on("click", "#loadMoreBtn", function () {
    $.ajax({
        url: "/Courses/LoadMoreCourses/",
        type: "get",
        data: {
            "skip": skip
        },
        success: function (response) {
            console.log(response)
           /* $("#myCoursesList").append(response)*/
            //skip += 6;
            //if (skip >= coursesCount) {
            //    $("#loadMoreBtn").remove()
            //}
        }
    });
});