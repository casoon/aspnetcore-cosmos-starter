using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Starter.Core;
using Starter.Core.Entities;

namespace Starter.ODataWebAPI.Controllers
{
  public class ProductsController : ODataController
  {

    private readonly StarterDbContext _context;

    public ProductsController(StarterDbContext context)
    {
      this._context = context;
    }

    [ODataRoute("Orders")]
    [EnableQuery(AllowedOrderByProperties = "createdAt")]
    public IQueryable<Product> GetOrders(ODataQueryOptions opts)
    {
      String test = opts.OrderBy.OrderByClause.ToString();

      return _context.Products;
      //return context.Orders.OrderBy(x=>x.CreatedAt);
    }
  }
}
