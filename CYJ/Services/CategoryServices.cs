using CYJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CYJ.Services
{
    public class CategoryServices : IDisposable
    {
        private readonly dorothyEntities _dbContext;

        public CategoryServices()
        {
            _dbContext = new dorothyEntities(); //STILL HAVE TO DISPOSE
        }

        public List<CATEGORY> GetAllCategories()
        {

            return _dbContext.CATEGORies.ToList();
        }

        public List<CATEGORY> GetCategoriesList(int wstreamID)
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;

            return _dbContext.CATEGORies.Where(x => x.wstreamID == wstreamID).ToList();
        }
        public CATEGORY GetCategoryById(int id)
        {
            return _dbContext.CATEGORies.SingleOrDefault(t => t.categID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }
    }
}