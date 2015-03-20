(function() {
    'use strict';

    var baseUrl = '/Scripts/appDir/',
        components = baseUrl + "components/",
        modules = baseUrl + "modules/";

    angular.module('myApp', ['ui.router'])
        .config([
            '$urlRouterProvider',
            '$stateProvider',
            function($urlRouterProvider, $stateProvider) {

                $stateProvider
                    .state('home', {
                        url: '/home',
                        views: {
                            '': { templateUrl: components + 'views/home/indexTpl.html' },
                            'menu@home': { templateUrl: components + 'shared/_navigation.html' }
                        },
                        controller: 'homeCtrl',
                        controllerAs: 'home'

                    })                   
                    .state('login', {
                        url: '/',
                        templateUrl: components + 'views/login/loginTpl.html',
                        controller: 'loginCtrl',
                        controllerAs: 'login'
                    });

                $urlRouterProvider.otherwise("/");


            }
        ]);

})();