$(document).ready(function () {
    UpdateStaffListDiv();
});
function UpdateStaffListDiv() {
    $.ajax({
        url: '/Staff/GetStaffList',
        type: 'GET',
        dataType: 'html',
        success: function (data) {
            $(".v2-staff-list-div").val('Loading Staffs..........................');
            $(".v2-staff-list-div").html(data);
        },
        error: function (err) {
        }
    });
}
function AddNewStaff() {
    var formdata = $("#form-add").serializeArray();
    $.ajax({
        url: '/Staff/AddStaff',
        type: 'POST',
        data: { FirstName: formdata[0].value, LastName: formdata[1].value, RoleID: formdata[2].value },
        success: function () {
            UpdateStaffListDiv();
            $('#form-add').trigger("reset");
        }
    });
    return false;
}
function DeleteStaff(Id) {
    $.ajax({
        url: '/Staff/Delete',
        type: 'POST',
        data: { StaffID: Id },
        beforeSubmit: function(){     
        },
        success: function () {
            UpdateStaffListDiv();
        }
    })
    return false;
}
function UpdateStaff() {
    var formdata = $("#form-update").serializeArray();
    //$("#div-pop-up-update-staff").css('display', 'block');
    $.ajax({
        url: '/Staff/Update',
        type: 'POST',
        data: {StaffID:  formdata[0].value, FirstName: formdata[1].value, LastName: formdata[2].value, RoleID: formdata[3].value },
        success: function () {
            UpdateStaffListDiv();
            $("#div-pop-up-update-staff").html("");
        }
    });
    return false;
}
function PopUpData(Id) {
    $.ajax({
        url: '/Staff/PopUp',
        type: 'GET',
        data: {StaffID : Id},
        dataType: 'html',
        success: function (data) {
            $("#div-pop-up-update-staff").html(data);          
        }
    });
    return false;
}
