$(document).ready(function () {
    const GetAllEquipmentUrl = 'Equiptment/GetAllEquipment';
    const GetAllEquipmentColumns = [
        { data: "equiptmentName" },
        { data: "equiptmentDescription" },
        { data: "maxReserveTimeMinute" },
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
            return `<button class="btn btn-success" onclick="changePath('/Equiptment/UpdateEquipment?equipmentId=${row.id}')">Update</button>
          <button class="btn btn-danger" onclick="DeleteEquipment('${row.id}')">Delete</button>`

        } }
    ];
    GenerateTable(GetAllEquipmentUrl, '#equipment-table', GetAllEquipmentColumns, '');
    GetEquipmentValById();
});

const InsertEquipment = async () => {

    let equipment = {
        EquiptmentName: $('#txtEquipmentName').val(),
        EquiptmentDescription: $('#txtEquipmentDescription').val(),
        MaxReserveTimeMinute: $('#txtEquipmentReserveTime').val(),
    }
   
    let url = '/Equiptment/InsertEquipment';
    await AjaxPOST(url, {
        equipmentData : equipment
    });
    alert("Equipment Added!");

    changePath('/equiptment');
}

const GetEquipmentValById = async () => {
    let equipmentId = getQueryParameter('equipmentId');
    if (!equipmentId) {
        return;
    }

    let url = `/Equiptment/GetEquipmentById?equipmentId=${equipmentId}`;
    const response = await AjaxGET(url);
    console.log(response);

    $("#updateEquipmentName").val(response.equipment.equiptmentName);
    $("#updateEquipmentDescription").val(response.equipment.equiptmentDescription);
    $("#updateEquipmentReserveTime").val(response.equipment.maxReserveTimeMinute);
 
}

const UpdateEquipment = async () => {

    let equipment = {
        EquiptmentName: $('#updateEquipmentName').val(),
        EquiptmentDescription: $('#updateEquipmentDescription').val(),
        MaxReserveTimeMinute: $('#updateEquipmentReserveTime').val(),
    }
  
    let url = `/Equiptment/UpdateEquipmentData`;
    await AjaxPOST(url, {
        equiptmentData: equipment
    });
    alert("Equipment updated successfully!");

    changePath('/equiptment')
}

const DeleteEquipment = async (equipmentId) => {

    if (!confirm("Are you sure you want to delete this equipment?")) {
        return;
    }

    let url = `/Equiptment/DeleteEquipment?equipmentId=${equipmentId}`;
    await AjaxPOST(url, {});
    alert("Equipment deleted successfully!");

    ReloadTable('#equipment-table');

}