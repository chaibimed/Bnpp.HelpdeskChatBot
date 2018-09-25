using System.Collections.Generic;
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
}