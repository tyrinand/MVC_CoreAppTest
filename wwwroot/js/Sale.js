$(document).ready(function () {
    $('select').formSelect();
    fullUpdate();

    $("#Soft").change(function () {
        fullUpdate();
    });

    $("#Count").change(function () {
        GetFullPrice();
    });

    $("#DiscountId").change(function () {
        GetFullPrice();
    });

    function fullUpdate() {
        movePrice();
        GetFullPrice();
    }

    function movePrice() {
        var selectId = $("#Soft").val();
        var price = $("#Soft > option[value=" + selectId + "]").attr('price');
        $("#one-price").val(price);
    }

    function GetFullPrice() {

        var count = $("#Count").val(); //кол-во
        var price = $("#one-price").val(); // софт + цена
        var selectedDis = $("#DiscountId").val();
        var discount = $("#DiscountId > option[value=" + selectedDis + "]").attr('disValue'); //получение величины скидки
        

        if (count === "" || price === "" || discount === "") {
            $("#full-price").val("-");
        }
        else {
            discount = parseFloat(discount.replace(",", "."));
            var fullPrice = count * price;
            fullPrice = Truncate(fullPrice * ((100 - discount) / 100));
            $("#full-price").val(fullPrice);
        }

    }

    function Truncate(value) {
        if (value < 0) {
            return Math.ceil(value);
        }
        return Math.floor(value);
    }
});
