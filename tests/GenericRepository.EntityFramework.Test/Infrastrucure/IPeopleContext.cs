using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GenericRepository.EntityFramework.Test.Infrastrucure {
    
    public interface IPeopleContext : IDisposable, IEntitiesContext {

        IDbSet<Person> People { get; set; }
        IDbSet<Book> Books { get; set; }
    }
}