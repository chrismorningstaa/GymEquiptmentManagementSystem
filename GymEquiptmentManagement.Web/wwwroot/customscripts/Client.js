$(document).ready(function () {
    
    const GetAllClientUrl = '/Client/GetAllClient';
    const GetAllClientColumns = [
        { data: "firstName" },
        { data: "lastName" },
        {
            data: "birthDate",
            render: function (data) {
                var date = new Date(data);
                var dateString = date.getFullYear() + '/'
                    + ('0' + (date.getMonth() + 1)).slice(-2) + '/'
                    + ('0' + date.getDate()).slice(-2);

                return dateString;
            }
        },
        { data: "gender" },
        {
            data: "action", render: (data, type, row) => { 
                console.log(row);
                return `<button class="btn btn-success" onclick="changePath('/Client/UpdateClient?clientId=${row.id}&userId=${row.id}')">Update</button>
          <button class="btn btn-danger" onclick="DeleteClient('${row.id}')">Delete</button>`

        } }
    ];
    GenerateTable(GetAllClientUrl, '#client-table', GetAllClientColumns, '')
    GetClientValById();

  
});

const InsertClient = async () => {

    let client = {
        FirstName: $('#txtAddClientFirstName').val(),
        LastName: $('#txtAddClientLastName').val(),
        BirthDate: $('#txtAddClientBirthDate').val(),
        Gender: $('#selectAddClientGender').val(),
    }
    let user = {
        UserName: $('#txtAddClientEmailAddress').val(),
        Password: $('#txtAddClientPassword').val(),
        UserType: $('#selectAddClientUserType').val(),
        Email: $('#txtAddClientEmailAddress').val(),
    }

    let url = '/Client/InsertClient';
    await AjaxPOST(url, {
        clientData : client,
        userData : user
    });
    alert("Client Added!");

    changePath('/client');
}

const GetClientValById = async () => {
    let clientId = getQueryParameter('clientId');
    if (!clientId) {
        return;
    }
    let userId = getQueryParameter('userId');
    if (!userId) {
        return;
    }
    let url = `/Client/GetClientById?clientId=${clientId}&userId=${userId}`;
    const response = await AjaxGET(url);
    console.log(response);

    $("#updateClientFirstName").val(response.client.firstName);
    $("#updateClientLastName").val(response.client.lastName);
    $("#updateClientBirthdate").val(response.client.birthDate);
    $("#updateClientGender").val(response.client.gender);

    $("#updateClientEmailAddress").val(response.user.userName);
    $("#updateClientPassword").val(response.user.password);
    $("#updateClientEmailAddress").val(response.user.email);
    $("#updateClientUserType").val(response.user.userType);
}

const UpdateClientData = async () => {

    let client = {
        FirstName: $('#updateClientFirstName').val(),
        LastName: $('#updateClientLastName').val(),
        BirthDate: $('#updateClientBirthdate').val(),
        Gender: $('#updateClientGender').val(),
    }
    let user = {
        UserName: $('#txtAddClientEmailAddress').val(),
        Password: $('#txtAddClientPassword').val(),
        UserType: $('#selectAddClientUserType').val(),
        Email: $('#txtAddClientEmailAddress').val(),
    }

    let url = `/Client/UpdateClientData`;
    await AjaxPOST(url, {
        clientData: client,
        userData: user
    });
    alert("Client updated successfully!");

    changePath('/client')
}

const DeleteClient = async (clientId) => {

    if (!confirm("Are you sure you want to delete this client?")) {
        return;
    } 

    let url = `/Client/DeleteClient?clientId=${clientId}`;
    await AjaxPOST(url, {});
    alert("Client deleted successfully!");

    ReloadTable('#client-table');

}

