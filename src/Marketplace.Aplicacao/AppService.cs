namespace Marketplace.Aplicacao
{
    public class AppService<TContext> where TContext :  new()
    {
        public virtual void BeginTransaction()
        {
        }
        public virtual void Commit()
        {
        }
    }
}
