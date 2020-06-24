﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MoOnlineStore.Core.Specifications
{
    public class BaseSpefication<T> : ISpecification<T>
    {
        public BaseSpefication()
        {
        }
        public BaseSpefication(Expression<Func<T, bool>> _cretaria)
        {
            Criteria = _cretaria;
        }
        public Expression<Func<T, bool>> Criteria { get; } 
        public List<Expression<Func<T, object>>> Includes {get;}
            = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        protected void AddInclude(Expression<Func<T, object>> IncludeExpression)
        {
            Includes.Add(IncludeExpression);
        }
        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        protected void AddOrderByDescending(Expression<Func<T, object>> OrderByDeseExpression)
        {
            OrderByDescending = OrderByDeseExpression;
        }
        protected void AddPagination(int skip,int take)
        {
            Take = take;
            Skip = skip;
            IsPagingEnabled = true;
        }
    }
}
