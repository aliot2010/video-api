using System;
using System.Collections.Generic;


namespace Video_api
{
    public class Client
    {
        public Client()
        {
            leases = new List<Lease>();
        }
        
        public string firstName{ get; set; }

        public string sername{ get; set; }
        
        public int age{ get; set; }
        
        public string sex{ get; set; }
        
        public int id{ get; set; }
        
        public DateTime registrationDate{ get; set; }
        
        public List<Lease> leases { get; set; }
    }
}