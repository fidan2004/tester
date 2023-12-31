﻿using MediatR;
using Kalles.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.BrandModule
{
    public class BrandGetAllQuery : IRequest<List<Brand>>
    {


        public class BrandGetAllQueryHandler : IRequestHandler<BrandGetAllQuery, List<Brand>>
        {
            public Task<List<Brand>> Handle(BrandGetAllQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
