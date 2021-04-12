using LibBD;
using LibPdvUth2021.App;
using System;
using System.Collections.Generic;

namespace LibPdvUth2021.Products
{
    public class Product : CRUD
    {
        //constructor
        public Product(): base("products", new List<string>(){ "id","name","description","price","bar_code","brand_id","subcategory_id","image","measure_unit","sku"})
        {
          
        }

        //attribs
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string barCode { get; set; }
        public string BrandID { get; set; }
        public int SubcategoryId { get; set; }
        public string MetricUnit { get; set; }
        public string Sku { get; set; }

        //CRUD
        public bool create (int id, string name, string description, double price, string barCode, int brandId, int subCategoryId, string metricUnit, string sku) 
        {
            List<DataCollection> data = new List<DataCollection>();
            data.Add(new DataCollection("id", Types.INT, id));
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("bar_code", Types.VARCHAR, barCode));
            data.Add(new DataCollection("brand_id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_id", Types.INT, subCategoryId));
            data.Add(new DataCollection("metric_unit", Types.VARCHAR, metricUnit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));
            return base.create(data);
        }

    }
}
