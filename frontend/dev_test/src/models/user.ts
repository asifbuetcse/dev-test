export class UserModel {
  public name: string;
  public email: string;
  public mobile: string;
  public isActive: string;
  public role: string;
  constructor(email: string, mobile: string, isActive: string, role: string, name: string) {
    this.email = email;
    this.mobile = mobile;
    this.isActive = isActive;
    this.role = role;
    this.name = name;
  }
}
