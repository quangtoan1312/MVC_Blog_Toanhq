using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Toanhq.Models;

namespace MVC_Blog_Toanhq.Repository
{
    public interface IBlogRepository<Blog>
    {
        
            List<Blog> GetBlogs();
            Blog Get(long? Id);
            int Create(BlogDto blogDto);
            int Edit(BlogDto blogDto);
            int Delete(long? Id);
            List<Blog> Search(string title);

        
    }
}
