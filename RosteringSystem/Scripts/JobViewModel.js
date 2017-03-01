function Update(id) {
    $(".form-update").animate({ top: '20%' });
    $.ajax({
        url: "/Jobs/Update",
        type: "GET",
        data: {id: id},
        contentType: "json",
        success: function (response) {
            $("#id").val(response.id);
            $("#name").val(response.name);
            $("#address").val(response.address);
        }
        });
    return false;
};
function UpdateDataBase() {
    //get values from the form
    var id = $('#id').val();
    var name = $('#name').val();
    var address = $('#address').val();
    $.ajax({
        type: 'POST',
        url: '/Jobs/UpdateDataBase',
        data: { id: id, name: name, address: address },
        beforeSend: function () {
            $('#btn-update-job').val("Updating......");
        },
        success: function (response) {
           //some code to reload the div
        }    
    })
}