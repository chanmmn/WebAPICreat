using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApp3.Models;

namespace MvcApp3.Controllers
{
  public class ValuesController : ApiController
  {
    // GET api/values
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    public void Post(Book value)
    {
      Book book = value;

      northwindEntities context = new northwindEntities();
      Product product = new Product();

      product.ProductName = book.title;

      context.Products.Add(product);
      context.SaveChanges();
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }
  }
}