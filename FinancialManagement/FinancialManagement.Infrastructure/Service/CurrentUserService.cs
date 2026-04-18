using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagement.Application.Constants;
using FinancialManagement.Application.Dto.User;
using FinancialManagement.Application.Interface;
using Microsoft.AspNetCore.Http;

namespace FinancialManagement.Infrastructure.Service
{
    public class CurrentUserService : ICurrentUserService
    {
        public required IHttpContextAccessor HttpContextAccessor;

        public async Task<GetCurrentUserResponseDto> GetCurrentUser()
        {
            var user = HttpContextAccessor.HttpContext?.User;
            var isAuthenticated = user?.Identity?.IsAuthenticated ?? false;

            if (!isAuthenticated)
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }

            var objectId = user?.FindFirst(ClaimTypesConstants.ObjectId)?.Value;

            if (string.IsNullOrWhiteSpace(objectId))
            {
                throw new UnauthorizedAccessException("User does not have a valid ObjectId.");
            }

            var name = user?.FindFirst(ClaimTypesConstants.Name)?.Value;
            var email = user?.FindFirst(ClaimTypesConstants.Email)?.Value;
            var role = user?.FindFirst(ClaimTypesConstants.Role)?.Value;

            var response = new GetCurrentUserResponseDto
            {
                Name = name,
                Email = email,
                IdentityProviderId = objectId,
                Role = role
            };

            return await Task.FromResult(response);
        }
    }
}
