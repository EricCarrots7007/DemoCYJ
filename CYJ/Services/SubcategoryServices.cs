using CYJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CYJ.Services
{
    public class SubcategoryServices
    {
        private readonly dorothyEntities _dbContext;

        public SubcategoryServices()
        {
            _dbContext = new dorothyEntities(); //STILL HAVE TO DISPOSE
        }

        public List<SUBCATEGORY> GetAllSubCategories()
        {

            return _dbContext.SUBCATEGORies.ToList();
        }

        public List<SUBCATEGORY> GetSubCategoriesList(int categID)
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;

            return _dbContext.SUBCATEGORies.Where(x => x.categID == categID).ToList();
        }
        public SUBCATEGORY GetSubCategoryById(int id)
        {
            return _dbContext.SUBCATEGORies.SingleOrDefault(t => t.subcategID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }
    }
}