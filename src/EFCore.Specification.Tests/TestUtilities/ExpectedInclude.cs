// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq.Expressions;

namespace Microsoft.EntityFrameworkCore.Specification.TestUtilities
{
    public class ExpectedInclude<TEntity> : IExpectedInclude
    {
        public Func<TEntity, object> Include { get; }
        public string IncludedName { get; }
        public string NavigationPath { get; }

        public ExpectedInclude(Expression<Func<TEntity, object>> include, string includedName, string navigationPath = "")
        {
            Include = include.Compile();
            IncludedName = includedName;
            NavigationPath = navigationPath;
        }
    }
}
