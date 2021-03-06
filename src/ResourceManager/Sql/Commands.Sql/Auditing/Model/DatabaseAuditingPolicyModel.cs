﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Sql.Auditing.Model
{
    /// <summary>
    /// The possible states in which the user server's policy property may be in
    /// </summary>
    public enum UseServerDefaultOptions { Enabled, Disabled }

    /// <summary>
    /// A class representing a database auditing policy
    /// </summary>
    public class DatabaseAuditingPolicyModel : BaseAuditingPolicyModel
    {
        /// <summary>
        /// Gets or sets the database name
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the use server default property
        /// </summary>
        public UseServerDefaultOptions UseServerDefault { get; set; }
    }
}