public interface IRepository<Entity>
{
    void Add(Entity entity);
    bool Edit(Expression<Func<Entity, bool>> predicate, Entity entity);
    bool Delete(Expression<Func<Entity, bool>> predicate);
    IEnumerable<Entity> GetAll();
    IQueryable<Entity> Find(Expression<Func<Entity, bool>> predicate);
    Entity Get(Expression<Func<Entity, bool>> predicate);
}