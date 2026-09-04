using MediatR;

namespace ECommerceAPI.Application;

public record ChangeUserRoleCommand(int CurrentUserId, ChangeUserRoleDto ChangeUserRoleDto) : IRequest<Unit>;