using WebApi.Services.Example.EndPoints.GetRandomNumber.Models;

namespace WebApi.Services.Example.EndPoints.GetRandomNumber;

public interface IGetRandomNumberService
{
    GetRandomNumberResultModel GetRandomNumber();
}
