﻿using System.Web;
using System.Web.Mvc;

namespace Net_Framework_Identity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
