using RabbitMQ.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Core.Data
{
    public class UsersDataModel : IDataModel<User>
    {
        public IEnumerable<User> GetData()
        {
            return new List<User>
            {
                new User{UserId=1,FirstName="İsmail",LastName="Kaşan",Email="ismailkasan63@gmail.com"}
               ,new User{UserId=2,FirstName="Saadet",LastName="Dingeç",Email="saadetdingec@piton.com.tr"}
               //,new User{UserId=3,FirstName="Vacip",LastName="Derici",Email="vacip.derici@ericssonmsp.com"}
               //,new User{UserId=4,FirstName="Talha",LastName="Seçkin",Email="taha.seckin@ericssonmsp.com"}
            };
        }
    }
}
