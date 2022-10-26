﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Phoenix_Store.Application.Services.Users.Commands.EditUser;
using Phoenix_Store.Application.Services.Users.Commands.UserStatusChange;
using Phoenix_Store.Application.Services.Users.Commands.RegisterUser;
using Phoenix_Store.Application.Services.Users.Commands.RemoveUser;
using Phoenix_Store.Application.Services.Users.Queries.GetRoles;
using Phoenix_Store.Application.Services.Users.Queries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using static Phoenix_Store.Application.Services.Users.Commands.RegisterUser.RegisterUserService;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IGetRolesService _getRolesService;
        private readonly IRemoveUserService _removeUserService;
        private readonly IUserStatusChangeService _userStatusChangeService;
        private readonly IEditUserService _editUserService;
        private readonly IRegisterUserService _registerUserService;
        public UsersController(IGetUsersService getUsersService
            , IGetRolesService getRolesService
            , IRemoveUserService removeUserService
            , IUserStatusChangeService userStatusChangeService
            , IEditUserService editUserService
            , IRegisterUserService registerUserService)
        {
            _getUsersService = getUsersService;
            _getRolesService = getRolesService;
            _removeUserService = removeUserService;
            _userStatusChangeService = userStatusChangeService;
            _editUserService = editUserService;
            _registerUserService = registerUserService;
        }
        
        public IActionResult Index(string searchkey, int page=1)
        {
            return View(_getUsersService.Execute(new RequestGetUserDto
            {
                Page = page,
                SearchKey = searchkey,
            }));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles =new SelectList(_getRolesService.Execute().Data,"Id","Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Email, string FullName, long RoleId, string Password, string RePassword)
        {
            var result = _registerUserService.Execute(new RequestRegisterUserDto
            {
                Email = Email,
                FullName = FullName,
                roles = new List<RolesInRegisterUserDto>()
                   {
                        new RolesInRegisterUserDto
                        {
                             Id= RoleId
                        }
                   },
                Password = Password,
                RePassword = RePassword,
            });
            return Json(result);
        }
        [HttpPost]
        public IActionResult Delete(long UserId)
        {
            return Json(_removeUserService.Execute(UserId));
        }
        [HttpPost]
        public IActionResult UserStatusChange(long UserId)
        {
            return Json(_userStatusChangeService.Execute(UserId));
        }
        [HttpPost]
        public IActionResult Edit(long UserId, string Fullname)
        {
            return Json(_editUserService.Execute(new RequestEditUserDto
            {
                UserId = UserId,
                Fullname = Fullname
            }));
        }
    }
}
