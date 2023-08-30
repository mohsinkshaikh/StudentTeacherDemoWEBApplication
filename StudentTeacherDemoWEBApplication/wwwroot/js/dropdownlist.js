$(document).ready(function () {
    $("#categoryID").change(function () {
        var id = $(this).var();
        $("#productID").empty();
        $("#productID").append('<option>Select Product Categories</option>');
        $.ajax({
            type: 'GET',
            url: '/CatProd/GetProductIdByCategoryId',
       
            success: function (result) {
                $("#productID").empty();
                $("#productID").append('<option>Select Product Categories</option>');
                $.each(result, function (index, data) {
                    $("#productID").append('<option value=' + data.ID + '>' + data.ProductName + '</option>');
                });
            }
        });
    });
});

function GetProduct() {
    
}


//function GetCategory() {
  
//        $.ajax({
//            url: '/CatProd/GetCategory',
//            type: 'GET',
//            success: function (result) {
//                $.each(result, function (index, data) {
//                    $("#categoryID").append('<option value=' + data.id + '>' + data.Name + '</option>');
//                });
//            }
//        });
   
//}
