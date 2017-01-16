/*--- Send Ajax ---*/
var MAX_XHR_WAITING_TIME = 5000;// in ms

var sendAjax = function (params) {
    var xhr = new XMLHttpRequest(),
            url = params.cache ? params.url + '?' + new Date().getTime() : params.url,
            timer = setTimeout(function () {// if xhr won't finish after timeout-> trigger fail
                xhr.abort();
                params.error && params.error();
                params.complete && params.complete();
            }, MAX_XHR_WAITING_TIME);
    xhr.open(params.type, url);
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            clearTimeout(timer);
            if (xhr.status === 200 || xhr.status === 0) {// 0 when files are loaded locally (e.g., cordova/phonegap app.)
                params.success && params.success(xhr.responseText);
                params.complete && params.complete();
            } else {
                params.error && params.error(xhr.responseText);
                params.complete && params.complete();
            }
        }
    };
    params.beforeSend && params.beforeSend(xhr);
    xhr.send();
};


/*--- Get JSON by url ---*/
var getJSON = function (params) {
    sendAjax({
        type: 'get',
        url: window.location.origin + "/api/personne/" + params.id,
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Accept', 'application/json, text/javascript');
        },
        success:OnSuccess,
        error: params.error,
        complete: params.complete,
        cache: true
    });
};

function OnSuccess(response) {
    var personne = JSON.parse(response);

    var html = "Id: " + personne.BusinessEntityID + "<br/>";
    html += "FirstName: " + personne.FirstName + "<br/>";
    html += "LastName: " + personne.LastName + "<br/>";

    var details = document.getElementById("details")
    details.innerHTML = html;
}

