using System;
using System.Collections.Generic;

namespace mConstruct_WebApi.Models
{
    public partial class FttxTaskmaster1
    {
        public decimal? Objectid { get; set; }
        public string Taskid { get; set; }
        public string Tasktype { get; set; }
        public string Fsaid { get; set; }
        public string Dsaid { get; set; }
        public string Csaid { get; set; }
        public string Mduid { get; set; }
        public string Layer { get; set; }
        public string Status { get; set; }
        public short? Feederno { get; set; }
        public string Contractorname { get; set; }
        public DateTime? Contractordate { get; set; }
        public string Acceptorname { get; set; }
        public DateTime? Acceptordate { get; set; }
        public string Contractorid { get; set; }
        public string Contractorcompany { get; set; }
        public short? Rev { get; set; }
        public string Appversion { get; set; }
        public string Constructorname { get; set; }
        public string Constructorid { get; set; }
        public DateTime? Constructordate { get; set; }
        public string Role { get; set; }
    }
}
