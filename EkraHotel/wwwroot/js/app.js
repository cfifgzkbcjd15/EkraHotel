'use strict';

function registrationUser ()
{
    location.href = 'http://localhost:5217/index.html?#registrationUser'
}

function registrationAdmin()
{
    location.href = 'http://localhost:5217/index.html?#registrationAdmin'
}

(function () {
    function init() {
        var router = new Router([
            new Route('loginUser', 'loginUser.html', true),            
            new Route('loginAdministrator', 'loginAdministrator.html'),
            new Route('registrationUser', 'registrationUser.html'),
            new Route('registrationAdmin', 'registrationAdmin.html')
        ]);
    }
    init();
}());
