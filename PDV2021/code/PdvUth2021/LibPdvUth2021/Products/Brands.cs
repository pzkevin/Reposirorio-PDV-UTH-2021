using LibBD;
using LibPdvUth2021.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibPdvUth2021.Products
{
    class Brands : CRUD
    {
        //constructor
        public Brands() : base("brands", new List<string>() {  "id", "name", "description", "logo" })
        {

        }

        //attribs
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }

        //CRUD
        public bool create(string id, string name, double description, string logo)
        {
            List<DataCollection> data = new List<DataCollection>();
            data.Add(new DataCollection("id", Types.INT, id));
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("logo", Types.VARCHAR, logo));
            bool res = base.create(data);
            if (!res) this.ERROR = BD.ERROR;
            return res;
        }

        //public bool update(string id, string name, double description, string logo)
        //{
        //    List<DataCollection> data = new List<DataCollection>();
        //    data.Add(new DataCollection("id", Types.INT, id));
        //    data.Add(new DataCollection("name", Types.VARCHAR, name));
        //    data.Add(new DataCollection("description", Types.VARCHAR, description));
        //    data.Add(new DataCollection("logo", Types.VARCHAR, logo));
        //    return base.update(data, id);
        //}

        public bool delete(int id)
        {
            return base.delete(id);
        }



    }
}
