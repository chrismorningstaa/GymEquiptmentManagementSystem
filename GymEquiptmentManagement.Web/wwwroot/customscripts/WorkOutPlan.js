$(document).ready(function () {
    const GetAllWorkoutPlanUrl = 'Workoutplan/GetAllWorkOutPlan';
    const GetAllWorkoutPlanColumns = [
        { data: "workOutPlanName" },
        { data: "workOutPlanDescription" },
        { data: "price" },
            {
            data: "dateAdded",
            render: function (data) {
                var date = new Date(data);
                var dateString = date.getFullYear() + '/'
                    + ('0' + (date.getMonth() + 1)).slice(-2) + '/'
                    + ('0' + date.getDate()).slice(-2);

                return dateString;
            }
        },
        { data: "action", render: (data, type, row) => {
                return `<button class="btn btn-success" onclick="changePath('/Workoutplan/UpdateWorkOutPlan?workoutplanId=${row.id}')">Update</button>
          <button class="btn btn-danger" onclick="DeleteWorkOutPlan('${row.id}')">Delete</button>`

         }  }
    ];
    GenerateTable(GetAllWorkoutPlanUrl, '#workoutplan-table', GetAllWorkoutPlanColumns, '');
    GetWorkOutPlanValById();
    GetWorkOutValById();
});

const InsertWorkOutPlan = async () => {

    let workoutplan = {
        WorkoutPlanName: $('#txtWorkOutPlanName').val(),
        WorkOutPlanDescription: $('#txtWorkOutPlanDescription').val(),
        Price: $('#txtPrice').val(),

    }

    let url = '/Workoutplan/InsertWorkOutPlan';
    await AjaxPOST(url, {
        workoutplanData: workoutplan
    });
    alert("Work Out Plan Added!");

    changePath('/workoutplan');
}

const GetWorkOutPlanValById = async () => {
    let workoutplanId = getQueryParameter('workoutplanId');
    if (!workoutplanId) {
        return;
    }

    let url = `/Workoutplan/GetWorkOutPlanById?workoutplanId=${workoutplanId}`;
    const response = await AjaxGET(url);
    console.log(response);

    $("#updateWorkOutPlanName").val(response.workoutplan.workOutPlanName);
    $("#updateWorkOutPlanDescription").val(response.workoutplan.workOutPlanDescription);
    $("#updatePrice").val(response.workoutplan.price);
}

const GetWorkOutValById = async () => {
    let workoutId = getQueryParameter('workoutId');
    if (!workoutId) {
        return;
    }

    let url = `/Workout/GetWorkOutById?workoutId=${workoutId}`;
    const response = await AjaxGET(url);
    console.log(response);

    $("#updateWorkOutName").val(response.workout.workoutName);
}

const UpdateWorkOutPlan = async () => {

    let workoutplan = {
        WorkOutPlanName: $('#updateWorkOutPlanName').val(),
        WorkOutPlanDescription: $('#updateWorkOutPlanDescription').val(),
        Price: $('#updatePrice').val(),

    }

    let url = `/Workoutplan/UpdateWorkOutPlanData`;
    await AjaxPOST(url, {
        workoutplanData: workoutplan
    });
    alert("Work Out Plan updated successfully!");

    changePath('/workoutplan')
}

const DeleteWorkOutPlan = async (workoutplanId) => {

    if (!confirm("Are you sure you want to delete this workoutplan?")) {
        return;
    }

    let url = `/Workoutplan/DeleteWorkOutPlan?workoutplanId=${workoutplanId}`;
    await AjaxPOST(url, {});
    alert("Work Out Plan deleted successfully!");

    ReloadTable('#workoutplan-table');

}

const PopulateWorkout = async () => {

    $("#WorkoutName").val($("#selectAddWorkout").val());
    let workoutId = $("#selectAddWorkout").val();
    console.log(workoutId);
    let url = `/Workout/GetWorkOutById?workoutId=${workoutId}`
    await AjaxGET(url);

}