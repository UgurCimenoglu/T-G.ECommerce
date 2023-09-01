
$(document).ready(function () {
    var categoryId = null;
    var maxPrice = null;
    var minPrice = null;
    var orderBy = null;
    var rating = null;
    var currentPage = 0;

    var getCategories = function () {
        $.ajax({
            url: 'https://localhost:7038/api/Category',
            type: 'GET',
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                //$("#categoryDiv").html("")
                $.each(data, function (i, item) {
                    var category = "<div class='form-check'>" +
                        "<input class='form-check-input' type='radio' name='categoryRadios' id='categoryRadios' value=" + item.id + " >" +
                        "<label class='form-check-label' for='exampleRadios1'>" + item.name + "</label></div>";
                    $("#categoryDiv").append(category)
                })
            },
            error: function (error) {
                console.log(error)
            }
        });
    }
    getCategories();

    var request = function () {
        $.ajax({
            url: "https://localhost:7038/api/Products?Page=" + currentPage + "&PageSize=9",
            type: 'POST',
            data: JSON.stringify({ categoryId: categoryId, minPrice: minPrice, maxPrice: maxPrice, orderBy: orderBy, rating: rating }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $("#productDiv").html("");
                $.each(data.items, function (i, item) {
                    var product = "<div class='col-4 my-2'>" +
                        "<div class='card'>" +
                        "<img class='card-img-top' src = 'https://dosaandchaat.com/templates/default-new/images/no-product-found.png' alt = 'Card image cap' >" +
                        "<div class='card-body'>" +
                        "<h5 class='card-title' >" + item.name + "</h5>" +
                        "<p class='card-text'>" + item.description + "</p>" +
                        "<div class='d-flex justify-content-between align-items-center' >" +
                        "<a href='#' class='btn btn-primary'>Sepete Ekle </a>" +
                        "<strong class='fs-5'>₺" + item.price + "</strong>" +
                        "</div>" +
                        "</div>" +
                        "</div>" +
                        "</div>";
                    console.log(item)
                    $("#productDiv").append(product)
                })
                var pagination =
                    (data.hasPrevious ? "<li class='page-item'><a class='page-link' href ='#' aria-label='Previous'><span aria-hidden='true'></span><span class='sr-only'>Previous</span></a></li> " : "<li class='page-item disabled'><a class='page-link' href ='#' aria-label='Previous'><span aria-hidden='true'></span><span class='sr-only'>Previous</span></a></li> ") +
                    (data.hasPrevious ? "<li class='page-item'><a class='page-link' href='#'>" + (data.index) + "</a></li>" : "") +
                    "<li class='page-item active'><a class='page-link' href='#'>" + (data.index + 1) + "</a></li>" +
                    (data.hasNext ? "<li class='page-item'><a class='page-link' href='#'>" + (data.index + 2) + "</a></li>" : "") +
                    (data.hasNext ? "<li class='page-item'><a class='page-link' href='#' aria-label='Next'><span aria-hidden='true'></span><span class='sr-only'>Next</span></a></li>" : "<li class='page-item disabled'><a class='page-link' href='#' aria-label='Next'><span aria-hidden='true'></span><span class='sr-only'>Next</span></a></li>");
                console.log(pagination)
                $(".pagination").html(pagination);
            },
            error: function (error) {
                console.log(error)
            }
        });
    }
    request();

    $('#categoryDiv').on("click", "#categoryRadios", function () {
        categoryId = $("input[name='categoryRadios']:checked").val() == "all" ? null : $("input[name='categoryRadios']:checked").val();
        currentPage = 0;
        request();
    });
    $('input[name="minPrice"]').change(function () {
        minPrice = $("input[name='minPrice']").val() == "" ? null : $("input[name='minPrice']").val();
        currentPage = 0;
        request();
    });
    $('input[name="maxPrice"]').change(function () {
        maxPrice = $("input[name='maxPrice']").val() == "" ? null : $("input[name='maxPrice']").val();
        currentPage = 0;
        request();
    });
    $('input[name="orderBy"]').change(function () {
        orderBy = $("input[name='orderBy']:checked").val() == "" ? null : $("input[name='orderBy']:checked").val();
        currentPage = 0;
        request();
    });
    $('input[name="rating"]').change(function () {
        rating = $("input[name='rating']:checked").val() == "" ? null : $("input[name='rating']:checked").val();
        currentPage = 0;
        request();
    });
    $('.pagination').on("click", ".page-link", function (e) {
        e.preventDefault();
        currentPage = $(this).text() == "Previous" ? (parseInt(currentPage) - 1) : $(this).text() == "Next" ? (parseInt(currentPage) + 1) : (parseInt($(this).text()) - 1);
        request()

    });

});
