﻿using FoodletAPI.Entities;
using FoodletAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodletAPI.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<List<RoleModel>> GetRoleListByUserId(string id);
    }
}
