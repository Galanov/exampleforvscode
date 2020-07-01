using System.Collections.Generic;

namespace Test.Models
{
    public interface IRepository
    {
        IEnumerable<GuestResponse> Responses{get;}
        void AddResponse(GuestResponse response);
    }
}