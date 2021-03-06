// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq.Expressions;
using System.Threading;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Query.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public class CompiledQuery<TContext, TResult> : CompiledQueryBase<TContext, TResult>
        where TContext : DbContext
    {
        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public CompiledQuery([NotNull] LambdaExpression queryExpression)
            : base(queryExpression)
        {
        }

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult Execute(
            [NotNull] TContext context)
            => ExecuteCore(context);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult Execute<TParam1>(
            [NotNull] TContext context,
            [CanBeNull] TParam1 param1)
            => ExecuteCore(context, param1);

#pragma warning disable CA1068 // CancellationToken parameters must come last
        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult ExecuteAsync<TParam1>(
#pragma warning restore CA1068 // CancellationToken parameters must come last
            [NotNull] TContext context,
            CancellationToken cancellationToken,
            [CanBeNull] TParam1 param1)
            => ExecuteCore(context, param1);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult Execute<TParam1, TParam2>(
            [NotNull] TContext context,
            [CanBeNull] TParam1 param1,
            [CanBeNull] TParam2 param2)
            => ExecuteCore(context, param1, param2);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult Execute<TParam1, TParam2, TParam3>(
            [NotNull] TContext context,
            [CanBeNull] TParam1 param1,
            [CanBeNull] TParam2 param2,
            [CanBeNull] TParam3 param3)
            => ExecuteCore(context, param1, param2, param3);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult Execute<TParam1, TParam2, TParam3, TParam4>(
            [NotNull] TContext context,
            [CanBeNull] TParam1 param1,
            [CanBeNull] TParam2 param2,
            [CanBeNull] TParam3 param3,
            [CanBeNull] TParam4 param4)
            => ExecuteCore(context, param1, param2, param3, param4);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual TResult Execute<TParam1, TParam2, TParam3, TParam4, TParam5>(
            [NotNull] TContext context,
            [CanBeNull] TParam1 param1,
            [CanBeNull] TParam2 param2,
            [CanBeNull] TParam3 param3,
            [CanBeNull] TParam4 param4,
            [CanBeNull] TParam5 param5)
            => ExecuteCore(context, param1, param2, param3, param4, param5);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        protected override Func<QueryContext, TResult> CreateCompiledQuery(
            IQueryCompiler queryCompiler, Expression expression)
            => queryCompiler.CreateCompiledQuery<TResult>(expression);
    }
}
