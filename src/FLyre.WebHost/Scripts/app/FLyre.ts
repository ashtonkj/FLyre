
var FLyre = angular
  .module('FLyre', ['ngResource', 'ngRoute', 'ngAnimate'])
  .config(function ($routeProvider) {
    $routeProvider.when('/', {
      templateUrl: '/Home/Home'//,
      //controller: 'HomeController'
    });
  })
  .run(function ($rootScope) {
  });

