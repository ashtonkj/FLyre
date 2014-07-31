module FLyre.Services {
    export class PresentationService {
      HideMenu() {
        if ($(".navbar-collapse").hasClass("in")) {
          $(".navbar-collapse").removeClass("in");
          $(".navbar-collapse").addClass("collapse");
        }
      }
    }
}

FLyre.Application.FLyre.service('PresentationService', function ($http, $q) {
  return new FLyre.Services.PresentationService();
});