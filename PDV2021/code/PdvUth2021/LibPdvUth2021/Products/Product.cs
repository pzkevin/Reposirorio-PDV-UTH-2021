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
        public bool create (string name, string description, double price, string barCode, int brandId, int subCategoryId, string metricUnit, string sku) 
        {
            List<DataCollection> data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("price", Types.VARCHAR, price));
            data.Add(new DataCollection("bar_code", Types.VARCHAR, barCode));
            data.Add(new DataCollection("brand_id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_id", Types.INT, subCategoryId));
            data.Add(new DataCollection("measure_unit", Types.VARCHAR, metricUnit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));
            bool res = base.create(data);
            if (!res) this.ERROR = BD.ERROR;
            return res;
        }

        public bool update(string name, string description, double price, string barCode, int brandId, int subCategoryId, string metricUnit, string sku, int id)
        {
            List<DataCollection> data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("bar_code", Types.VARCHAR, barCode));
            data.Add(new DataCollection("brand_id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_id", Types.INT, subCategoryId));
            data.Add(new DataCollection("metric_unit", Types.VARCHAR, metricUnit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));
            return base.update(data, id);
        }

        public bool delete(int id)
        {
            return base.delete(id);
        }

        public List<List<object>> barScan(string barCode)
        {
            List<SearchCollection> data = new List<SearchCollection>();
            data.Add(new SearchCollection("bar_code", CriteriaOperator.EQUAL, barCode, true, LogicOperator.NOTHING));
            return base.read(data);
        }
    }
}
