using System;

namespace Video_api
{
    public class Lease
    {   
        public DateTime dateOfIssue{ get; set; }
        public DateTime dateOfReturn{ get; set; }
        
        public Medium medium{ get; set; }
        
        public int id{ get; set; }
    }
}