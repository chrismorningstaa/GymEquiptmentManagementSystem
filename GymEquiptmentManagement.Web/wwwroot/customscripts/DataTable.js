const GenerateTable = async (url, tableId, columns, dataSrc) => {
    const data = await AjaxPOST(url, null);
    $(tableId).DataTable({
        ajax: {
            url: url,
            data: data,
            dataSrc: dataSrc,
        },
        columns: columns,
    });
};

const ReloadTable = async (tableId) => {
    $(tableId).DataTable().ajax.reload();
}