
using Microsoft.EntityFrameworkCore.Design;
using MySql.EntityFrameworkCore.Extensions;

namespace uszo___eb

{
    public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection sevicecollection)
        {
            sevicecollection.AddEntityFrameworkMySQL();
            new EntityFrameworkRelationalDesignServicesBuilder(sevicecollection).TryAddCoreServices();
        }
    }
}
