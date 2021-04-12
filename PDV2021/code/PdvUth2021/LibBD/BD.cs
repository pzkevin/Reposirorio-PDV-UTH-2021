using System;
using System.Collections.Generic;

namespace LibBD
{
    public abstract class BD
    {
        /// <summary>
        /// This Super Class helps to define CONCRETE class that will execute DB actions
        /// employing this attributes to generate ConectionString to each DBMS.
        /// </summary>
        //props
        public static string ERROR;
        //db props
        public string SERVER { get; set; }
        public string DBNAME { get; set; }
        public string US { get; set; }
        public string PWD { get; set; }
        public string PORT { get; set; }




        //métodos abstractos
        /// <summary>
        /// Create a new ROW in the stablished table on the parameters. 
        /// </summary>
        /// <param name="table"> The table that will creates a new row  </param>
        /// <param name="data">  The data that will be used to create the new row. It includes the field name, type and Value </param>
        /// <returns>True if the row is created. Flase if there's an Error. </returns>
        public abstract bool create(string table, List<DataCollection> data);
        /// <summary>
        /// Updates a ROW with the ID and Data provided in the parameters, on the field
        /// </summary>
        /// <param name="table"> the table will update the ROW with the ID on input </param>
        /// <param name="data">The data that will UPDATE the ROW in question    </param>
        /// <param name="id">The ID of the ROW to be updated    </param>
        /// <returns>True if the row is created. Flase if there's an Error. </returns>
        public abstract bool update(string table, List<DataCollection> data, int id);
        public abstract bool delete(string table, int id);
        public abstract List<List<object>> read(List<string> fields, string table, List<SearchCollection> data);
        public abstract List<List<object>> read(List<string> fields, string table1, string table2, List<string> onfields, List<SearchCollection> data);
        public abstract List<List<object>> index(string table, OrderBy order);
        /// <summary>
        /// Opens the connection to the SERVER stablished by the connectionString
        /// </summary>
        /// <returns></returns>
        public abstract bool Connect();
        
        /// <summary>
        /// Closes the connection to the SERVER stablished by the connectionString
        /// </summary>
        /// <returns></returns>
        public abstract bool Disconnect();
    }
}
