﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfPortfolioSectionDal :GenericRepository<PortfolioSection>,IPortfolioSectionDal
    {
        public EfPortfolioSectionDal(MyPorfolioContext context) : base(context)
        {
        }
    }
}
