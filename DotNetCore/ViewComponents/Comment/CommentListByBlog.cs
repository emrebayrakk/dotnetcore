﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Concrete;
using DAL.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private CommentManager cm = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
