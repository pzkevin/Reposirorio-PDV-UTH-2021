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

    }
}
