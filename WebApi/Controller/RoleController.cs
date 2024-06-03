using Domain.DTOs.RoleDTOs;
using Domain.Filters;
using Infrastructure.Permissions;
using Infrastructure.Services.RoleService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class RoleController(IRoleService roleService) : ControllerBase
{
    [HttpGet("roles")]
    [PermissionAuthorize(Permissions.Roles.View)]
    public async Task<IActionResult> GetRoles([FromQuery] PaginationFilter filter)
    {
        var response = await roleService.GetRolesAsync(filter);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("{roleId:int}")]
    [PermissionAuthorize(Permissions.Roles.View)]
    public async Task<IActionResult> GetRoleById(int roleId)
    {
        var response = await roleService.GetRoleByIdAsync(roleId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost("create")]
    [PermissionAuthorize(Permissions.Roles.Create)]
    public async Task<IActionResult> CreateRole([FromBody] CreateRoleDto createRole)
    {
        var result = await roleService.CreateRoleAsync(createRole);
        return StatusCode(result.StatusCode, result);
    }


    [HttpPut("update")]
    [PermissionAuthorize(Permissions.Roles.Edit)]
    public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleDto updateRole)
    {
        var result = await roleService.UpdateRoleAsync(updateRole);
        return StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{roleId:int}")]
    [PermissionAuthorize(Permissions.Roles.Delete)]
    public async Task<IActionResult> DeleteRoleAsync(int roleId)
    {
        var result = await roleService.DeleteRoleAsync(roleId);
        return StatusCode(result.StatusCode, result);
    }
}