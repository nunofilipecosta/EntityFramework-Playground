using CostaSoftware.EFCorePlayground.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaSoftware.EFCorePlayground.DataAccess
{
    public static class DatabaseSeed 
    {
        public static void Initialize(BloggingContext context)
        {
            // Look for any students.
            if (context.Blogs.Any())
            {
                return;   // DB has been seeded
            }

            var blogs = new Blog[]
            {
                new Blog { Url = "http://nunofilipecosta.wordpress.com" }
            };

            context.Blogs.AddRange(blogs);
            context.SaveChanges();

            var posts = new Post[]
            {
                new Post { Title = "The first post", Content = "The first post content", BlogId = blogs[0].BlogId },
                new Post { Title = "The second post", Content = "The second post content", BlogId = blogs[0].BlogId },
            };

            context.Posts.AddRange(posts);
            context.SaveChanges();
        }
    }
}
