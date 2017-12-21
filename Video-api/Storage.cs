using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Storage.Blob.Protocol;

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
            
            var film1 = new Film();
            film1.id = 1;
            film1.actors = "Jim Jim, Jim Jim";
            film1.ageLimit = 12;
            film1.country = "Belarus";
            film1.producer = "Alexei Lazarev";
            film1.summory = "Summory Summory Summory Summory Summory Summory";
            film1.title = "MU MU ";
            film1.yearOfIssue = 2013;
            
            var category = new Category();
            category.id = 0;
            category.nameOfCategory = "Adventure";
            category.categoryCode = category.nameOfCategory.Substring(0, 3);
            
            categorys.Add(category);
                
            film.cathegory = category;
            film1.cathegory = category;
            
            films.Add(film);
            films.Add(film1);
            
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
            film1.copiesIds.Add(medium3.id);
            
            
            var lease = new Lease();
            lease.id = 0;
            lease.dateOfIssue = new DateTime();
            lease.medium = medium3;
            
            leases.Add(lease);
            
            var lease1 = new Lease();
            lease1.id = 1;
            lease1.dateOfIssue = new DateTime();
            lease1.medium = medium1;
            
            leases.Add(lease1);
            
            var client1 = new Client();
            var client2 = new Client();

            client1.id = 0;
            client1.firstName = "Oleg";
            client1.sername = "Put";
            client1.leases.Add(lease);
            client1.age = 19;
            client1.registrationDate = new  DateTime();
            client1.sex = "man";
            
            client2.id = 1;
            client2.firstName = "Anton";
            client2.sername = "Check";
            client2.leases.Add(lease1);
            client2.age = 19;
            client2.registrationDate = new  DateTime();
            client2.sex = "man";
            
            
            clients.Add(client1);
            clients.Add(client2);
        }

        public Film getFilmById(int id)
        {
            foreach (var film in films)
            {
                if (film.id == id)
                {
                    return film;
                }
            }

            return null;
        } 
        
        public void setFilmById(int id, Film film)
        {
            for (int i = 0; i < films.Count; i++)
            {
                if (films[i].id == id)
                {
                    films[i] = film;
                }
            }
        } 
        
        public Category getCategoryById(int id)
        {
            foreach (var category in categorys)
            {
                if (category.id == id)
                {
                    return category;
                }
            }

            return null;
        } 
        
        public void setCategoryById(int id, Category category)
        {
            for (int i = 0; i < categorys.Count; i++)
            {
                if (categorys[i].id == id)
                {
                    categorys[i] = category;
                }
            }
        } 
        
        public Client getClientById(int id)
        {
            foreach (var client in clients)
            {
                if (client.id == id)
                {
                    return client;
                }
            }

            return null;
        } 
        
        public void setClientById(int id, Client client)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].id == id)
                {
                    clients[i] = client;
                }
            }
        } 
         
        public List<Film> films { get; set;}
        public List<Client> clients { get; set;}
        public List<Medium> mediums { get; set;}
        public List<Lease> leases { get; set;}
        public List<Category> categorys { get; set;}
    }
}