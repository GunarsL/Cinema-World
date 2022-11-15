using Cinema_World.Models;

namespace Cinema_World.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<ActorModel>> GetAll();
        ActorModel GetById(int ActorID);
        void Add(ActorModel Actor);
        ActorModel Update(int ActorID, ActorModel newActor);
        void Delete(int ActorID);
    }
}
