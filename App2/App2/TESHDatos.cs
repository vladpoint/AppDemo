using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace App2
{
    public class TESHDatos
    {
        string id;
        string dato1;
        string dato2;
        bool deleted;
        //[PrimaryKey,Unique,MaxLength(5)]
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //[Column("Nombre"),MaxLength(20)]
        [JsonProperty(PropertyName = "dato1")]
        public string Dato1
        {
            get { return dato1; }
            set { dato1 = value; }
        }
        //[Column("Apellido"),MaxLength(20)]
        [JsonProperty(PropertyName = "dato2")]
        public string Dato2
        {
            get { return dato2; }
            set { dato2 = value; }
        }
        [Version]
        public string Version { get; set; }
        [JsonProperty(PropertyName ="deleted")]
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
