function GetStaffsByShift(id) {
    $.ajax({
        url: '/Home/StaffListByShift',
        type: 'GET',
        data: { StaffId: id },
        contentType: 'json',
        success: function (response) {
            //do something here...
            //console.log(response);
            //$.each(response, function (i, item) {
            //    // alert(response[i].FirstName);
            //    alert("");
            //});
        }

    });
return false;
};