using Microsoft.EntityFrameworkCore;
using ChuckWarsAPI.Models;
using Newtonsoft.Json;
using ChuckWarsAPI.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace ChuckWarsAPI.Data
{
    public class ApiContext : DbContext
    {

 
       
        public DbSet<StarWars> starwars { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {
          

        }

    }
}
