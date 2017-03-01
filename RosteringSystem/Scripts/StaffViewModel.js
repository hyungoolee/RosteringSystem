function Update(id) {
    $(' .form-update').animate({ top: '20%' });
    $.ajax({
        url: "/Staff/Update",
        type: 'GET',
        data: {StaffId: id},
        contentType: 'json',
        success: function (response) {
            $("#StaffId").val(response.ID);
            $("#FName").val(response.FirstName);
            $("#LName").val(response.LastName);
        }
        });
    return false;
};
function UpdateDataBase() {
    //get values from the form
    var staff_id = $('#StaffId').val();
    var staff_f_name = $('#FName').val();
    var staff_l_name = $('#LName').val();
    $.ajax({
        type: 'POST',
        url: '/Staff/UpdateDataBase',
        data: { StaffId: staff_id, FirstName: staff_f_name, LastName: staff_l_name },
        success: function (response) {
            window.location.href = "/Staff/Index";
        }    
    })

    return false;
}