using System.Collections.Generic;

namespace Test.Models
{
    public class EFRepository: IRepository
    {
        private ApplictionDbContext context = new ApplictionDbContext();

        public IEnumerable<GuestResponse> Responses => context.Invites;

        public void AddResponse(GuestResponse response){
            context.Invites.Add(response);
            context.SaveChanges();
        }
    }
}