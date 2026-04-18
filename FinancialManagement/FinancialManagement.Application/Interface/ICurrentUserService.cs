using FinancialManagement.Application.Dto.User;

namespace FinancialManagement.Application.Interface
{
    public interface ICurrentUserService
    {
        Task<GetCurrentUserResponseDto> GetCurrentUser();
    }
}
