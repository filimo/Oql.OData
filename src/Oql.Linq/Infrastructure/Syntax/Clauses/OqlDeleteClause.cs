﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Oql.Linq.Api.Syntax;
using Oql.Linq.Infrastructure.Syntax.Methods;

namespace Oql.Linq.Infrastructure.Syntax.Clauses
{
    public class OqlDeleteClause : OqlBaseClause
    {
        internal static Method DeleteInfo = new Method<IQueryable<object>>(x => x.Delete());

        public override void ProcessMethodCall(IOqlSyntaxContext callContext, MethodCallExpression methodCall)
        {

        }

        public override void VisitTo(IOqlExpressionVisitor visitor)
        {
            visitor.Query.AppendDelete().AppendBlank();
        }
    }
}
