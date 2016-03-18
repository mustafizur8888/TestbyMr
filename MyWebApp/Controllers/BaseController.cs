﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App.Model;

namespace MyWebApp.Controllers
{
    public class BaseController : ApiController
    {
        protected BusinessDbContext Db;

        public BaseController()
        {
            Db = new BusinessDbContext();
            
        }
    }
}
