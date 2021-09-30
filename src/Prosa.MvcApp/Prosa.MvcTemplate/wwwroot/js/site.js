////$("#btn").click(function () {
////    $.getJSON("/data", function (data) {
////        let ul = $("#lst");
////        ul.empty();
////        for (var i = 0; i < data.length; i++) {
////            let li = $("<li />").html(data[i].navn);
////            ul.append(li);
////        }
////    });
////});

$("#btn").click(async function () {
    let data = await $.getJSON("/data");
    let ul = $("#lst");
    ul.empty();
    for (var i = 0; i < data.length; i++) {
        let li = $("<li />").html(data[i].navn);
        ul.append(li);
    }
});