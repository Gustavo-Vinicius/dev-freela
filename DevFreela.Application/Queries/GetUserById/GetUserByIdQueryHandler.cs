using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetUserByIdQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<UserViewModel?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
             var user = _dbContext.Users.SingleOrDefault(u => u.Id == request.Id);

            if (user == null)
            {
                return Task.FromResult<UserViewModel?>(null);
            }   

            return Task.FromResult<UserViewModel?>(new UserViewModel(user.FullName, user.Email));
        }
    }
}