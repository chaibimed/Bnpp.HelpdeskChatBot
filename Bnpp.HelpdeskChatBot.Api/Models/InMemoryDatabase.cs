using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;

namespace Bnpp.HelpdeskChatBot.Api.Models
{

    public class Repository : IRepository
    {
        private InMemoryDatabase _db;
        public Repository(IOptions<InMemoryDatabase> db)
        {
            this._db = db.Value;
        }
        public IList<string> GetApplications()
        {
            return _db.Applications;
        }
    }
    public class InMemoryDatabase 
    {
        public List<string> Applications { get; set; }

        public List<string> Features { get; set; }
        
    }
    
    
}