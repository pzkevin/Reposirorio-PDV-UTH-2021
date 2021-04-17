using LibBD;
using LibPdvUth2021.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibPdvUth2021.Users
{
    public class User : CRUD
    {
        //contructor
        public User() : base("users", new List<string>() { "id", "name", "lastname", "mothers_lastname", "email", "password", "type", "street", "house_number", "residential", "postal_code", "region_state", "CURP", "RFC" })
        {

        }
        //attribs
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double MothersLastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Residential { get; set; }
        public string PostalCode { get; set; }
        public string RegionState { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }

        //public List<List<object>> barScan(string barCode)
        //{
        //    List<SearchCollection> data = new List<SearchCollection>();
        //    data.Add(new SearchCollection("bar_code", CriteriaOperator.EQUAL, barCode, true, LogicOperator.NOTHING));
        //    return base.read(data);
        //}

        public bool Login(string email, string password) 
        {
            List<SearchCollection> temp = new List<SearchCollection>();
            SearchCollection UsPw = new SearchCollection("email", CriteriaOperator.EQUAL, (object)email, true, LogicOperator.NOTHING);
            temp.Add(UsPw);
            UsPw = new SearchCollection("password", CriteriaOperator.EQUAL, (object)UsPw, true, LogicOperator.NOTHING);
            temp.Add(UsPw);

            List<List<object>> res = base.read(new List<string>() { "email" }, temp);

            if (res.Count == 0 || res.Count > 1)
                return false;
            else
                return true;
        }

    }
}
