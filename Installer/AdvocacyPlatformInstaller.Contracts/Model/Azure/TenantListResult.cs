﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
namespace AdvocacyPlatformInstaller.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Model representing a list of tenants.
    /// </summary>
    public class TenantListResult : AzureValueCollectionResponse<Tenant>
    {
    }
}
