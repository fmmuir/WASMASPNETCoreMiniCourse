using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Server.Data;

public sealed class MiniCourseDbContext : DbContext
{
    public DbSet<Post> Posts => Set<Post>();

    public MiniCourseDbContext(DbContextOptions<MiniCourseDbContext> options) : base(options: options) { }

    protected override void OnModelCreating(ModelBuilder builder) 
    {
        var PostsToSeed = new Post[6];
        for (int i = 1; i <= 6; i++)
        {
            PostsToSeed[i - 1] = new Post() 
            {
                PostId = i,
                Title = $"Post {i}",
                Content = $"The {i} post has some interesting content check it out"
            };
        }

        builder.Entity<Post>().HasData(data: PostsToSeed);

    }
}

