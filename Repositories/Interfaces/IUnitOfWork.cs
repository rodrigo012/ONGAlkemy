using OngProject.Entities;
namespace OngProject.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UsersRepository { get; }
        IGenericRepository<Comment> CommentsRepository { get; }
        IGenericRepository<Category> CategoriesRepository { get; }
        IGenericRepository<News> NewsRepository { get; }
        IGenericRepository<Activity> ActivitiesRepository { get; }
        IGenericRepository<Organization> OrganizationsRepository { get; }
        IGenericRepository<Testimonial> TestimonialsRepository { get; }
        IGenericRepository<Contact> ContactsRepository { get; }
        IGenericRepository<Member> MembersRepository { get; }
        IGenericRepository<Slide> SlidesRepository { get; }
    }
}
