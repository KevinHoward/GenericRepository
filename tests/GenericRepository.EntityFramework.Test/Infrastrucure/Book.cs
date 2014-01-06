using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepository.EntityFramework.Test.Infrastrucure {
    
    public class Book : IEntity {

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public DateTimeOffset PublishedOn { get; set; }

        public Person Person { get; set; }
    }
}