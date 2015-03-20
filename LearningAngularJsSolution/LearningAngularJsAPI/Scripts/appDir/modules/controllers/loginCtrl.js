(function() {
    'use strict';

    var loginCtrl = function($state, LoginService, UserData) {

        this.userLogin = function() {

            var data = {
                username: this.username,
                password: this.password
            };

            LoginService.userLogin(data, function() {

                UserData.username = data.username;
                $state.go('');

            });

        };

    };

    angular.module('myApp').controller('loginCtrl',
        [
            '$state',
            'LoginService',
            'UserData',

            loginCtrl

        ]);


})();