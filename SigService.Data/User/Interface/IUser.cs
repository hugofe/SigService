using System;
using System.Collections.Generic;
using System.Text;

namespace SigService.Data.User
{
    interface IUser
    {
        int UserId { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Departament { get; set; }
    }
}
