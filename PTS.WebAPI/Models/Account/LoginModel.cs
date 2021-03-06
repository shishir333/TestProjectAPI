﻿using System;
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
        public string Login { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        public int Pin { get; set; }

        /// <summary>
        /// The facility the user is at, if blank, the user’s default facility is used
        /// </summary>
        [Required]
        public string Facility { get; set; }
    }

    /// <summary>
    /// Response model for Login
    /// </summary>
    public class LoginResponseModel : IModelBase
    {
        /// <summary>
        /// Username
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// API Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The facility the user was signed into
        /// </summary>
        public string Facility { get; set; }
    }
}