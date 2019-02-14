$(function () {

    'use strict';

    $('#DefaultEmpText').val($('#CurrentEmpValue option:selected').text());
    $('#EmpFieldName').val($('#EmpFieldLabel').text());

    $('form#EmpForm').on('submit', function (e) {

        e.preventDefault();
        $('#CurrentEmpText').val($('#CurrentEmpValue option:selected').text());

        var $form = $(this);

        var $data = $form.serialize();
        var $type = $form.attr('method');
        var $url = $form.attr('action');

        $.ajax({
            type: $type,
            data: $data,
            url: $url,
            success: function (data) {
                console.log(data);
                $('#ajaxContent').html(data);
            }
        });
    });
});