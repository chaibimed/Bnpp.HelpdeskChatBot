using System.Collections.Generic;

namespace Bnpp.HelpdeskChatBot.Api.Models
{
    public interface IRepository
    {
        IList<string> GetApplications();
    }
}