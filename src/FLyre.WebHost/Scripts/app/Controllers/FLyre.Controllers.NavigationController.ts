module FLyre.Controllers {
    export class NavigationController {
      $scope: any;
      $location: ng.ILocationService;
      presentationService: FLyre.Services.PresentationService;
      constructor($rootScope, $scope, $location: ng.ILocationService, presentationService) {
        this.$scope = $scope;
        this.presentationService = presentationService;
        var that = this;
        $rootScope.$on("$locationChangeStart", function (event, next, current) {
          that.presentationService.HideMenu();
        });
      }
    }
}

FLyre.Application.FLyre.controller('NavigationController', function ($rootScope, $scope, $location: ng.ILocationService, PresentationService) {
  return new FLyre.Controllers.NavigationController($rootScope, $scope, $location, PresentationService);
});