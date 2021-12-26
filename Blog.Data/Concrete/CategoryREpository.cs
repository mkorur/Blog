﻿using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Blog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Concrete
{
    public class CategoryREpository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryREpository(DbContext context) : base(context)
        {

        }
    }
}