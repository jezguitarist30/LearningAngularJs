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

    angular
        .module('login', [])
        .config([
            '$stateProvider', function($stateProvider) {

                $stateProvider
                    .state('login', {
                        url: '/login',
                        templateUrl: 'app/components/views/login/login.html',
                        controllerAs: 'login', //Alias
                        controller: 'LoginCtrl'

                    });

            }
        ])
        .controller('LoginCtrl', ['$state', 'LoginService', 'UserData', loginCtrl]);


})();