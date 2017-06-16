using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.Areas.Admin.Models
{
    public class RolesCheckbox
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public string Name { get; set; }
    }

    public class UsersIndex
    {
        public IEnumerable<User> Users { get; set; }
    }

    public class UsersNew
    {
        public IList<RolesCheckbox> Roles { get; set; }

        [Required, MaxLength(128)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, MaxLength(256)]
        public string Email { get; set; }
    }

    public class UsersEdit
    {
        public IList<RolesCheckbox> Roles { get; set; }

        [Required, MaxLength(128)]
        public string Username { get; set; }

        [Required, MaxLength(256)]
        public string Email { get; set; }
    }

    public class UsersResetPassword
    {
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}