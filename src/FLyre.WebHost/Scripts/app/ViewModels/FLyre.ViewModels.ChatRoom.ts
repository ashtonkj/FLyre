module FLyre.ViewModels {
  export class ChatRoom {
    RoomName: string;
    Users: UserSummary[];
    private makeUser(userName): UserSummary  {
      var user = new UserSummary();
      user.UserName = userName;
      return user;
    }

    constructor(roomName) {
      this.RoomName = roomName;
      this.Users = new Array<UserSummary>();
      this.Users.push(this.makeUser("toyvo"));
      this.Users.push(this.makeUser("Johan Larsson"));
      this.Users.push(this.makeUser("Reed Copsey"));
      this.Users.push(this.makeUser("AshtonKJ"));
    }
  }
}