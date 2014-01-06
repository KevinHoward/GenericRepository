using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GenericRepository.EntityFramework.Test.Infrastrucure {

    public class PeopleContext : EntitiesContext, IPeopleContext {

        public IDbSet<Person> People { get; set; }
        public IDbSet<Book> Books { get; set; }
    }
}