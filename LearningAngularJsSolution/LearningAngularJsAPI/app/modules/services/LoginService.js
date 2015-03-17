(function () {
    'use strict';

    var loginService = function () {
        this.login = function (data, callback) {
            //something with the data
            callback();
        };
    };

    angular
      .module('myApp')
      .service('LoginService', [
        loginService
      ]);


})();