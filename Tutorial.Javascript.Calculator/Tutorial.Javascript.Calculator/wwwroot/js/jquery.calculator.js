$(function () {

    GenerateCalc();
});

function GenerateCalc() {
    var $denom = $('#denominator');

    $('.container').on('keyup', $denom, function (e) {

        $('.container').find($('.tbody')).empty();

        if ($($denom).val().length === 0) {
            $('.timesTable').hide();
        } else {
            $('.timesTable').show();
        }

        var row;
        var column;
        var arr = [];
        var $num = $($denom).val();

        if ($num > 100) {
            $('.container').find($('.tbody')).text('The number is too big.');
        } else {

            for (row = 1; row <= $num; row++) {
                var result = '<tr>';
                for (column = 1; column <= $num; column++) {
                    result += '<td width="20px" style="cursor: default" title="' + row + ' x ' + column + '">'
                        + (row * column) + '</td>';
                }
                result += '</tr>';
                arr.push(result);
            }
            $.each(arr, function (i, v) {
                $('.container').find($('.tbody')).append(v);
            });
        }
    });
}