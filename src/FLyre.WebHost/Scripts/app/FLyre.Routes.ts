function RegisterRoutes($routeProvider: ng.route.IRouteProvider) {
  $routeProvider.when('/', {
    templateUrl: '/Home/Home'//,
    //controller: 'HomeController'
  });
  $routeProvider.when('/Account', {
    templateUrl: '/Account'//,
    //controller: 'HomeController'
  });
  $routeProvider.when('/Chat', {
    templateUrl: '/Chat'//,
    //controller: 'HomeController'
  });
}