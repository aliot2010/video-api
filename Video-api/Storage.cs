using System;
using System.Collections.Generic;

namespace Video_api
{
    public class Storage
    {
        private static Storage instance;
 
        public static Storage getInstance()
        {
            if (instance == null)
                instance = new Storage();
            return instance;
        }
        
        private Storage()
        {
            films = new List<Film>();
            clients = new List<Client>();
            mediums = new List<Medium>();
            leases = new List<Lease>();
            categorys = new List<Category>();
            generateData();
        }

        private void generateData()
        {
            var film = new Film();
            film.id = 0;
            film.actors = "Alexei Lazarev, Jim Jim";
            film.ageLimit = 18;
            film.country = "USA";
            film.producer = "Alexei Lazarev";
            film.summory = "Summory Summory Summory Summory Summory Summory";
            film.title = "My first pain";
            film.yearOfIssue = 2017;
            
            var category = new Category();
            category.id = 0;
            category.nameOfCategory = "Adventure";
            category.categoryCode = category.nameOfCategory.Substring(0, 2);
            
            categorys.Add(category);
                
            film.cathegory = category;
            
            films.Add(film);
            
            var medium1 = new Medium();
            medium1.film = film;
            medium1.access = true;
            medium1.id = 0;
            medium1.typeOfMedium = "DVD";
            mediums.Add(medium1);

            
            var medium2 = new Medium();
            medium2.film = film;
            medium2.access = true;
            medium2.id = 1;
            medium2.typeOfMedium = "BlueRay";
            mediums.Add(medium2);
            
            var medium3 = new Medium();
            medium3.film = film;
            medium3.access = false;
            medium3.id = 2;
            medium3.typeOfMedium = "DVD";
            mediums.Add(medium3);
            
            film.copiesIds.Add(medium1.id);
            film.copiesIds.Add(medium2.id);
            film.copiesIds.Add(medium3.id);
            
            
            var lease = new Lease();
            lease.id = 0;
            lease.dateOfIssue = new DateTime();
            lease.medium = medium3;
            
            leases.Add(lease);
            
            var client1 = new Client();

            client1.id = 0;
            client1.firstName = "Oleg";
            client1.sername = "Put";
            client1.leases.Add(lease);
            client1.age = 19;
            client1.registrationDate = new  DateTime();
            client1.sex = "man";
            
            clients.Add(client1);
        }
        
        
         
        public List<Film> films { get; set;}
        public List<Client> clients { get; set;}
        public List<Medium> mediums { get; set;}
        public List<Lease> leases { get; set;}
        public List<Category> categorys { get; set;}
    }
}