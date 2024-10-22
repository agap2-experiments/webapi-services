using WebApi.Services.Example.EndPoints.GetRandomNumber.Models;

namespace WebApi.Services.Example.EndPoints.GetRandomNumber;

public class GetRandomNumberService : IGetRandomNumberService
{
    public GetRandomNumberResultModel GetRandomNumber()
    {
        return new()
        {
            GeneratedAt = DateTime.UtcNow,
            Number = new Random().Next()
        };
    }
}
