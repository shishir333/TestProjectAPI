using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTS.WebAPI.Models.Account
{
    /// <summary>
    /// Request model for Authentication
    /// </summary>
    public class AuthenticateRequestModel : IModelBase
    {
        /// <summary>
        /// Username
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// Pin
        /// </summary>
        [Required]
        public int Pin { get; set; }
    }

    /// <summary>
    /// Response model for Authentication
    /// </summary>
    public class AuthenticateResponseModel : IModelBase
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
    }
}