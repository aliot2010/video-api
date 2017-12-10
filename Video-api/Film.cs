using System.Collections.Generic;

namespace Video_api
{
    public class Film
    {
        public Film()
        {
            copiesIds = new List<int>();
        }
        
        public int id{ get; set; }
        
        public string title{ get; set; }
        
        public string producer{ get; set; }
        
        public string actors{ get; set; }
        
        public string country{ get; set; }
        
        public int yearOfIssue{ get; set; }
        
        public int ageLimit{ get; set; }
        
        //public int countOfCopies{ get; set; }
        
        public string summory{ get; set; }
        
        //public string movieScenesUrls
        public Category cathegory{ get; set; }
        
        public List<int> copiesIds { get; set; }
    }
}