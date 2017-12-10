namespace Video_api
{
    public class Medium
    {
        public int id{ get; set; }
        
        public Film film{ get; set; }
        
        public string typeOfMedium{ get; set; }
        
        public  bool access {get; set; }
    }
}