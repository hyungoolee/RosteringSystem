//function Update(id) {
//    $(' .form-update').animate({ top: '20%' });
//    $.ajax({
//        url: "/Staff/Update",
//        type: 'GET',
//        data: {StaffId: id},
//        contentType: 'json',
//        success: function (response) {
//            $("#StaffId").val(response.ID);
//            $("#FName").val(response.FirstName);
//            $("#LName").val(response.LastName);
//        }
//        });
//    return false;
//};
//function UpdateDataBase() {
//    //get values from the form
//    var staff_id = $('#StaffId').val();
//    var staff_f_name = $('#FName').val();
//    var staff_l_name = $('#LName').val();
//    $.ajax({
//        type: 'POST',
//        url: '/Staff/UpdateDataBase',
//        data: { StaffId: staff_id, FirstName: staff_f_name, LastName: staff_l_name },
//        beforeSend: function () {
//            $('#btn-update-staff').val("Updating......");
//        },
//        success: function (response) {
//           //some code to reload the div
//        }    
//    })
//}

function UpdateStaffListDiv() {
    $.ajax({
        url: '/Staff/GetStaffList',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var rows = ' ';
            $.each(data, function (i, item) {
                alert(item.FirstName);
                rows += "<tr>";
                rows += "<td>" + item.Id + "</td>";
                rows += "<td>" + item.FirstName + "</td>";
                rows += "<td>" + item.LastName + "</td>";
                rows += "<td><button onclick='return DeleteStaff("+item.Id+")'>Delete</button></td>";
                rows += "<td><button>Update</button></td></tr>";
                $("#v2-staff-list-table tbody").html(rows);
            });
        },
        error: function (err) {

        }
    });
}
function AddNewStaff() {

}
function DeleteStaff(Id){

}
$(document).ready(function () {
    UpdateStaffListDiv();
});