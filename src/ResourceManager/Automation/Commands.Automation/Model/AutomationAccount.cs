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

using Microsoft.Azure.Commands.ResrouceManager.Automation.Common;

namespace Microsoft.Azure.Commands.ResrouceManager.Automation.Model
{
    using AutomationManagement = Microsoft.Azure.Management.Automation;

    /// <summary>
    /// The automation account.
    /// </summary>
    public class AutomationAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationAccount"/> class.
        /// </summary>
        /// <param name="resrouceGroupName">
        /// The resource group name.
        /// </param>
        /// <param name="automationAccount">
        /// The automation account.
        /// </param>
        public AutomationAccount(string resrouceGroupName, AutomationManagement.Models.AutomationAccount automationAccount)
        {
            Requires.Argument("ResrouceGroupName", resrouceGroupName).NotNull();
            Requires.Argument("AutomationAccount", automationAccount).NotNull();

            this.RerourceGroupName = resrouceGroupName;
            this.AutomationAccountName = automationAccount.Name;
            this.Location = automationAccount.Location;
            this.Plan = automationAccount.Properties.Sku.Family;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationAccount"/> class.
        /// </summary>
        public AutomationAccount()
        {
        }

        /// <summary>
        /// Gets or sets the resource group name.
        /// </summary>
        public string RerourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the automation account name.
        /// </summary>
        public string AutomationAccountName { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        public string Plan { get; set; }
    }
}
