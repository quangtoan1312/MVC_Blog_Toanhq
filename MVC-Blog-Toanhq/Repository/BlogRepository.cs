using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Toanhq.Models;

namespace MVC_Blog_Toanhq.Repository
{
    public class BlogRepository : IBlogRepository<Blog>
    {
        private BlogDbContext _dbContext = new BlogDbContext();

        public int Create(BlogDto blogDto)
        {
            Blog blog = new Blog();
            blog.Title = blogDto.Title;
            blog.Description = blogDto.Description;
            blog.Detail = blogDto.Detail;
            blog.Image = blogDto.Image;
            blog.Position = blogDto.Position;
            blog.Public = blogDto.Public;
            blog.Category = blogDto.Category;
            blog.PublicDate = blogDto.PublicDate;
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
            return 1;
        }

        public List<Blog> GetBlogs()
        {
            return _dbContext.Blogs.ToList();
        }

        public Blog Get(long? id)
        {
            return _dbContext.Blogs.FirstOrDefault(b => b.Id == id);
        }

        public BlogDto Edit(long? id)
        {
            Blog blog = _dbContext.Blogs.Find(id);
            BlogDto blogDto = new BlogDto();
            blogDto.Title = blog.Title;
            blogDto.Description = blog.Description;
            blogDto.Detail = blog.Description;
            blogDto.Image = blog.Image;
            blogDto.Position = blog.Position;
            blogDto.Public = blog.Public;
            blogDto.Category = blog.Category;
            blogDto.PublicDate = blog.PublicDate;
            return blogDto;
        }

        public int Edit(BlogDto blogDto)
        {
            Blog blog = _dbContext.Blogs.Find(blogDto.Id);
            blog.Title = blogDto.Title;
            blog.Description = blogDto.Description;
            blog.Detail = blogDto.Detail;
            blog.Image = blogDto.Image;
            blog.Position = blogDto.Position;
            blog.Public = blogDto.Public;
            blog.Category = blogDto.Category;
            blog.PublicDate = blogDto.PublicDate;
            return 1;
        }

        public int Delete (long? Id)
        {
            Blog blog = _dbContext.Blogs.Find(Id);
            _dbContext.Blogs.Remove(blog);
            _dbContext.SaveChanges();
            return 1;
        }

        public List<Blog> Search (string title)
        {
            List<Blog> list = new List<Blog>();
            if (!String.IsNullOrEmpty(title))
            {
                return list= _dbContext.Blogs.AsEnumerable().Where(post => post.Title.Contains(title)).ToList();
            }
            else
            {
                return _dbContext.Blogs.ToList();
            }
        }
    }
}
