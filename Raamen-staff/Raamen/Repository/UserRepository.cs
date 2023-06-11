using Raamen.Factory;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class UserRepository
    {
        public static RaamenEntities db = new RaamenEntities();

        public static User getUserFromEmailAndPassword(string email, string password)
        {
            return db.Users.Where(user => (user.Email == email || user.UserName == email) && user.Password == password).FirstOrDefault();
        }

        public static User createUser(string username, string email, string gender, string password)
        {
            return UserFactory.createUser(username, email, gender, password);
        }

        public static void addUser(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
        }
        public static User getUserByID(int id)
        {
            return db.Users.Where(user => user.Id == id).FirstOrDefault();
        }
        public static bool duplicateAccount(string email, string username)
        {
            return (db.Users.Where(user => user.Email == email || user.UserName == username).FirstOrDefault() == null);
        }

        //get all ramen
        public static List<Raman> getAllRamen()
        {
            return db.Ramen.ToList();
        }

        //find ramen based on ID
        public static Raman findRamenWithId(int id)
        {
            return db.Ramen.Find(id);
        }

        //update ramen
        public static void updateRamen(int id, int meatid, string name, string broth, string price)
        {
            Raman ramen = db.Ramen.Find(id);
            ramen.MeatId = meatid;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;
            db.SaveChanges();
        }

        //insert ramen
        public static void insertRamen(Raman ramen)
        {
            db.Ramen.Add(ramen);
            db.SaveChanges();
        }

        //delete ramen
        public static void deleteRamen(int id)
        {
            Raman ramen = db.Ramen.Find(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
        }
    }
}