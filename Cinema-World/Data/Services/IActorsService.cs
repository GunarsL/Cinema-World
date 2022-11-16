using Cinema_World.Models;

namespace Cinema_World.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<ActorModel>> GetAllAsync();
        Task<ActorModel> GetByIDAsync(int ActorID);
        Task AddAsync(ActorModel Actor);
        Task <ActorModel> UpdateAsync(int ActorID, ActorModel newActor);
        Task DeleteAsync(int ActorID);
    }
}
