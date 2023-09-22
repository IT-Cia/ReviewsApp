using ReviewsApp.Application;
using ReviewsApp.DataAccess;
using ReviewsApp.DataAccess.Entities;

namespace ReviewsApp.Infrastructure.Reviews
{
    public class ReviewService : IDataService<Review>
    {
        private readonly ApplicationDbContext dbContext;

        public ReviewService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Review> Get()
        {
            var query = dbContext.Reviews.OrderByDescending(x => x.Id);
            return query.ToList();
        }

        public Review GetById(int id)
        {
            var query = dbContext.Reviews.Where(x => x.Id == id);
            if (!query.Any())
                throw new Exception("Отзыв не найден");
            return query.First();
        }

        public List<Review> GetLast(int count)
        {
            var query = dbContext.Reviews.OrderByDescending(x => x.Id).Take(count);
            return query.ToList();
        }

        public List<Review> GetNext(int count, List<Review> previousItems)
        {
            var query = dbContext.Reviews.OrderByDescending(x => x.Id).Where(x => !previousItems.Contains(x)).Take(count);
            return query.ToList();
        }

        public void Add(Review item)
        {
            dbContext.Reviews.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = dbContext.Reviews.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Отзыв не найден");
            dbContext.Reviews.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
