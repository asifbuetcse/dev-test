export class UserModel {
  public email: string;
  public mobile: string;
  public isActive: string;
  public role: string;
  constructor(email: string, mobile: string, isActive: string, role: string) {
    this.email = email;
    this.mobile = mobile;
    this.isActive = isActive;
    this.role = role;

  }
}
