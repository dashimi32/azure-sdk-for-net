// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The web proxy settings on the device.
    /// </summary>
    public partial class WebproxySettings
    {
        /// <summary>
        /// Initializes a new instance of the WebproxySettings class.
        /// </summary>
        public WebproxySettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebproxySettings class.
        /// </summary>
        /// <param name="authentication">The authentication type. Possible
        /// values include: 'Invalid', 'None', 'Basic', 'NTLM'</param>
        /// <param name="username">The webproxy username.</param>
        /// <param name="connectionUri">The connection URI.</param>
        public WebproxySettings(AuthenticationType authentication, string username, string connectionUri = default(string))
        {
            ConnectionUri = connectionUri;
            Authentication = authentication;
            Username = username;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection URI.
        /// </summary>
        [JsonProperty(PropertyName = "connectionUri")]
        public string ConnectionUri { get; set; }

        /// <summary>
        /// Gets or sets the authentication type. Possible values include:
        /// 'Invalid', 'None', 'Basic', 'NTLM'
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public AuthenticationType Authentication { get; set; }

        /// <summary>
        /// Gets or sets the webproxy username.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
        }
    }
}