using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
       public string GetString()
        {
            return "你好，MVC!";
        }
        public Customer getCustomer()
        {
            //类型名  引用类型                                            
            Customer ct = new Customer();
            ct.CustomerName = "柳州职业技术学院";
            ct.Address = "软件技术2班";
            return ct;
        }
    }
}