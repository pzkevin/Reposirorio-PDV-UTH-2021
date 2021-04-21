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
        public string MothersLastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
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

        public User Login(string email, string password)
        {
            List<SearchCollection> data = new List<SearchCollection>();
            //data.Add( new SearchCollection("email", CriteriaOperator.EQUAL, email, true, LogicOperator.NOTHING));
            //data.Add( new SearchCollection("password", CriteriaOperator.EQUAL, password, true, LogicOperator.NOTHING));
            SearchCollection usEmail = new SearchCollection("email", CriteriaOperator.EQUAL, email, true, LogicOperator.NOTHING);
            SearchCollection usPassword = new SearchCollection("password", CriteriaOperator.EQUAL, password, true, LogicOperator.NOTHING);
            data.Add(usEmail);
            data.Add(usPassword);
            List<List<object>> res = base.read(data);

            //foreach (List<object> user in res)
            //{
            //    user[5].ToString();

            //}
            //return base.read(data).Count > 0 ? true : false; //operador ternario

            return new User()
            {
                Id = ((int)(res[0])[0]),
                Name = ((res[0])[1]).ToString(),
                Lastname = ((res[0])[2]).ToString(),
                MothersLastname = ((res[0])[3]).ToString(),
                Email = ((res[0])[4]).ToString(),
                Password = ((res[0])[5]).ToString(),
                Type = ((UserType)(res[0])[6]),
                Street = ((res[0])[7]).ToString(),
                HouseNumber = ((res[0])[8]).ToString(),
                Residential = ((res[0])[9]).ToString(),
                PostalCode = ((res[0])[10]).ToString(),
                RegionState = ((res[0])[11]).ToString(),
                CURP = ((res[0])[12]).ToString(),
                RFC = ((res[0])[13]).ToString()
            };
        }
    }
}
