module FLyre.Controllers {
  export class ChatRoomController {
    $scope: any;
    constructor($scope) {
      this.$scope = $scope;
      this.$scope.DataContext = new ViewModels.ChatRoom("F# General Discussions");
    }
  }
}

FLyre.Application.FLyre.controller("ChatRoomController", function ChatRoomController($scope) {
  return new FLyre.Controllers.ChatRoomController($scope);
});