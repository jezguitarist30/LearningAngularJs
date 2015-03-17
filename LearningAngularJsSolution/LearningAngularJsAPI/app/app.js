(function() {
    'use strict';


    angular.module('myApp', ['ui.router','login'])
        .config([
            '$urlRouterProvider', function($urlRouterProvider) {

                $urlRouterProvider.otherwise("/login");
            }
        ]);

})();