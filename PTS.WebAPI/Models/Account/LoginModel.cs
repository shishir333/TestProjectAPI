using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTS.WebAPI.Models.Account
{
    /// <summary>
    /// Request model for Login
    /// </summary>
    public class LoginRequestModel : IModelBase
    {
        /// <summary>
        /// Username
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        public string Password { get; set; }
    }

    /// <summary>
    /// Response model for Login
    /// </summary>
    public class LoginResponseModel : IModelBase
    {
        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Authentication Token (API Key)
        /// </summary>
        public string Key { get; set; }
    }
}