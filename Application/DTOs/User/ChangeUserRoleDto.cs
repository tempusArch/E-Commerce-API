using ECommerceAPI.Domain;

namespace ECommerceAPI.Application;

public class ChangeUserRoleDto {
    public int TargetUserId {get; set;}
    public UserRole UserRole {get; set;}
}