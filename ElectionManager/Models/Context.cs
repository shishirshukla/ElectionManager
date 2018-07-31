using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionManager.Models
{
    public class MyDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
       
        public DbSet<User> User { get; set; }
        public DbSet<Circle> Circle { get; set; }
        public DbSet<UserInCircle> UserInCircle { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<ZoneInfluencer> ZoneInfluencers { get; set; }
        public DbSet<ZoneIssue> ZoneIssues { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostInCircle> PostInCircles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionResponse> QuestionResponses { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<SurveyInCircle> SurveyInCircles { get; set; }
    }


}
