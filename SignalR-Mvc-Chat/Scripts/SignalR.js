
(function () {
    $.connection.hub.start()
        .done(function () {
            console.log("Hub works!");
            $.connection.chatHub.server.announce("Connected!");
        })
        .fail(function () {
            alert("Hub Failed!");
        });

    $.connection.chatHub.client.announce = function (message) {
        //$("#welcome-messages").text("");
        $("#welcome-messages").append(message + "<br/>");
    };

    
})(); //IIFE
