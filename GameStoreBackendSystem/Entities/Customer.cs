using GameStoreBackendSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreBackendSystem
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationaltiyId { get; set; }
        public DateTime BirthTime { get; set; }
    }
}
