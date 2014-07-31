module FLyre.Application {
    var $rootScopePtr;
    var $routeProviderPtr;

    export var FLyre = angular
      .module('FLyre', ['ngResource', 'ngRoute', 'ngAnimate'])
      .config(function ($routeProvider) {
        $routeProviderPtr = $routeProvider;

      })
      .run(function ($rootScope) {
        RegisterRoutes($routeProviderPtr);
      });
}


