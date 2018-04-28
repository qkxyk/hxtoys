using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using HX.Toys.Model;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace HX.Toys.Repository
{
    public abstract class EFRepositoryBase<TContext, TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class where TContext : DbContext
    {
        private readonly DbContext m_dbContext;

        public EFRepositoryBase()
            : this(Activator.CreateInstance<TContext>())
        {

        }

        public EFRepositoryBase(DbContext context)
        {
            this.m_dbContext = context;
        }

        public virtual bool Delete(TKey id)
        {
            try
            {
                var model = this.Get(id);
                this.GetSet().Remove(model);
                this.m_dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return this.GetSet().Where(predicate).ToList();
            }
            catch (Exception ex)
            {
                return new List<TEntity>();
            }
        }

        public TEntity Get(TKey id)
        {
            try
            {
                return this.GetSet().Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ICollection<TEntity> GetAll()
        {
            try
            {
                return this.GetSet().ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
            }
        }

        public TKey Insert(TEntity model)
        {
            try
            {
                this.GetSet().Add(model);
                this.m_dbContext.SaveChanges();
                IEntity<TKey> entity = model as IEntity<TKey>;
                return entity.Id;
            }
            catch (Exception ex)
            {
                return Activator.CreateInstance<TKey>();
            }
        }

        public bool Remove(TKey id)
        {
            try
            {
                var entity = this.GetSet().Find(id);
                GetSet().Remove(entity);
                this.m_dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool Update(TEntity model)
        {
            try
            {
                //RemoveHoldingEntityInContext(model);

                this.GetSet().Attach(model);
                m_dbContext.Entry(model).CurrentValues.SetValues(model);
                //this.m_dbContext.Entry(model).State = EntityState.Modified;
                this.m_dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(TEntity entity)
        {
            var objContext = ((IObjectContextAdapter)m_dbContext).ObjectContext;
            var objSet = objContext.CreateObjectSet<TEntity>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);
        }

        protected DbSet<TEntity> GetSet()
        {
            return this.m_dbContext.Set<TEntity>();
        }
    }
}
