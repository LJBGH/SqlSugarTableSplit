using Microsoft.AspNetCore.Mvc;
using SugarTableSplit.IServices;
using SugarTableSplit.Model.User;
using SugarTableSplit.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SugarTableSplit.Controllers
{
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {

            _userService = userService;
        }


        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        [Route("Api/User/GetUserList")]
        [HttpGet]
        public async Task<List<UserEntity>> GetUserList() 
        {
            return await _userService.GetUserList();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        [Route("Api/User/InsertUser")]
        [HttpPost]
        public async Task<string> InsertUser(UserEntity userEntity) 
        {
            return await _userService.InsertUser(userEntity);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        [Route("Api/User/UpdateUser")]
        [HttpPost]
        public async Task<string> UpdateUser(UserEntity userEntity)
        {
            return await _userService.UpdateUser(userEntity);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        [Route("Api/User/DeleteUser")]
        [HttpPost]
        public async Task<string> DeleteUser(UserEntity userEntity)
        {
            return await _userService.DeleteUser(userEntity);
        }


    }
}
