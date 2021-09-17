using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace nswag
{
    public class SpecController : specControllerBase
    {
        public override Task AddPet(long cookieParam, [FromBody] object body = null, [FromHeader(Name = "Accept-Language")] string accept_Language = "en-AU", CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task CreateUser([FromBody] User body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task CreateUsersWithArrayInput([FromBody] object body = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task CreateUsersWithListInput([FromBody] object body = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteOrder(string orderId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task DeletePet(long petId, [FromHeader] string api_key = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteUser(string username, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<Pet>> FindPetsByStatus([FromQuery] IEnumerable<Anonymous> status, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<Pet>> FindPetsByTags([FromQuery] IEnumerable<string> tags, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<IDictionary<string, int>> GetInventory(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<Order> GetOrderById(long orderId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<Pet> GetPetById(long petId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<User> GetUserByName(string username, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<string> LoginUser([FromQuery] string username, [FromQuery] string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task LogoutUser(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<Order> PlaceOrder([FromBody] Order body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<Response> Subscribe([FromBody] Body2 body = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task UpdatePet(long cookieParam, [FromBody] object body = null, [FromHeader(Name = "Accept-Language")] string accept_Language = "en-AU", CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task UpdatePetWithForm(long petId, [FromBody] Body body = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task UpdateUser(string username, [FromBody] User body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<ApiResponse> UploadFile(long petId, IFormFile body = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
