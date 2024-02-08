$(document).ready(function () {

    //Calculator functionality
    $('#calculate').click(function () {
        var hours = parseFloat($('#hours').val());
        if (!isNaN(hours) && hours > 0) {
            var chargePerHour = 20;
            var total = hours * chargePerHour;
            $('#total').text('$' + total.toFixed(2));
        } else {
            alert('Please enter a valid number of hours.');
        }
    });
});
