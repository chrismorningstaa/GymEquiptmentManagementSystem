$(document).ready(function () {
    const GetAllWorkoutUrl = 'Workout/GetAllWorkout';
    const GetAllWorkoutColumns = [
        { data: "workoutName" },
        { data: "workOutDescription" },
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
        {
            data: "action", render: (data, type, row) => {
                return `<button class="btn btn-success" onclick="changePath('/Workout/UpdateWorkOut?workoutId=${row.id}')">Update</button>
          <button class="btn btn-danger" onclick="DeleteWorkOut('${row.id}')">Delete</button>`

            }
        }
    ];
    GenerateTable(GetAllWorkoutUrl, '#workout-table', GetAllWorkoutColumns, '');
    GetWorkOutValById();
    GetEquipmentValById();
});

const InsertWorkOut = async () => {

    let workout = {
        WorkoutName: $('#txtWorkOutName').val(),
        WorkOutDescription: $('#txtWorkOutDescription').val(),

    }

    let url = '/Workout/InsertWorkOut';
    await AjaxPOST(url, {
        workoutData: workout
    });
    alert("WorkOut Added!");

    changePath('/workout');
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
    $("#updateWorkOutDescription").val(response.workout.workOutDescription);
}

const GetEquipmentValById = async () => {
    let equipmentId = getQueryParameter('equipmentId');
    if (!equipmentId) {
        return;
    }

    let url = `/Equiptment/GetEquipmentById?equipmentId=${equipmentId}`;
    const response = await AjaxGET(url);
    console.log(response);

    $("#updateEquipment").val(response.equipment.equiptmentName);

}

const UpdateWorkOut = async () => {

    let workout = {
        WorkoutName: $('#updateWorkOutName').val(),
        WorkOutDescription: $('#updateWorkOutDescription').val(),

    }

    let url = `/Workout/UpdateWorkOutData`;
    await AjaxPOST(url, {
        workoutData: workout
    });
    alert("WorkOut updated successfully!");

    changePath('/workout')
}

const DeleteWorkOut = async (workoutId) => {

    if (!confirm("Are you sure you want to delete this workout?")) {
        return;
    }

    let url = `/Workout/DeleteWorkOut?workoutId=${workoutId}`;
    await AjaxPOST(url, {});
    alert("WorkOut deleted successfully!");

    ReloadTable('#workout-table');

}

const PopulateEquipment = async () => {

    $("#EquiptmentName").val($("#selectAddEquipment").val());
    let equipmentId = $("#selectAddEquipment").val();
    console.log(equipmentId);
    let url = `/Equiptment/GetEquipmentById?equipmentId=${equipmentId}`
    await AjaxGET(url);

}