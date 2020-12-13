using System;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using Starter.Core.Entities;

namespace Starter.WebAPI
{
    public class OdataModelConfigurations : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion, string routePrefix)
        {
            builder.EntitySet<Product>("Products");
        }
    }
}
