using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionManager.Models
{
    public class Voter
    {
        public int  Id { get; set; }
        public String FullName { get; set; }
        public int CircleId { get; set; }
        public String MobileNumber { get; set; }
        public String Religion { get; set; }
        public String Caste { get; set; }
        public String Gender { get; set; }
        public String Status { get; set; }
        public bool isInfluencer { get; set; }
        public String Category { get; set; }
        public String EpicNumber { get; set; }
        public int Age { get; set; }
        public String Bio { get; set; }


    }
    public class UserInCircle
    {
        [Key()]
        public int Id { get; set; }
        public String UserId { get; set; }
        public int CircleId { get; set; }
        public String Setting1 { get; set; }
        public String Setting2 { get; set; }
        public int IntSetting1 { get; set; }
        public DateTime? DateSetting { get; set; }
        public DateTime? Created { get; set; }

    }
    public class Post
    {
        [Key()]
        public int Id { get; set; }
        public String PostText { get; set; }
        public String UserId { get; set; }
        public String PostType { get; set; }
        public String PostLink { get; set; }
        public int RelatedId { get; set; }
        public String PostAdditionalInfo1 { get; set; }
        public String PostAdditionalInfo2 { get; set; }
        public String PostAdditionalInfo3 { get; set; }
        public String PostAdditionalInfo4 { get; set; }
        public String PostStatus { get; set; }
        public DateTime? DateSetting { get; set; }
        public DateTime? Created { get; set; }

    }
    public class PostInCircle
    {
        [Key()]
        public int Id { get; set; }
        public int PostId { get; set; }
        public String UserId { get; set; }
        public int CircleId { get; set; }
        public String Setting1 { get; set; }
        public String Setting2 { get; set; }
        public int IntSetting1 { get; set; }
        public DateTime? DateSetting { get; set; }
        public DateTime? Created { get; set; }

    }
    public class PostView
    {
        [Key()]
        public int Id { get; set; }
        public String PostText { get; set; }
        public String UserId { get; set; }
        public String PostType { get; set; }
        public String PostLink { get; set; }
        public int RelatedId { get; set; }
        public String PostAdditionalInfo1 { get; set; }
        public String PostAdditionalInfo2 { get; set; }
        public String PostAdditionalInfo3 { get; set; }
        public String PostAdditionalInfo4 { get; set; }
        public String PostStatus { get; set; }
        public DateTime? DateSetting { get; set; }
        public DateTime? Created { get; set; }
        public String UserName { get; set; }
        public String UserProfilePic { get; set; }
        public String Circles { get; set; }
        public CommentView LatestComment { get; set; }
        public List<CommentView> Comments { get; set; }
        public bool hasComments { get; set; }
        public int TotalComments { get; set; }
        public int TotalReaction { get; set; }
        public Boolean HasReacted { get; set; }
    }
    public class Reaction
    {
        [Key()]
        public int Id { get; set; }
        public String ReactionType { get; set; }
        public String UserId { get; set; }
        public int RelatedId { get; set; }
        public String RelatedType { get; set; }
        public DateTime? Created { get; set; }

    }
    public class Comment
    {
        [Key()]
        public int Id { get; set; }
        public String UserId { get; set; }
        public int RelatedId { get; set; }
        public String RelatedType { get; set; }
        public String CommentText { get; set; }
        public DateTime? Created { get; set; }

    }
    public class CommentView
    {
        [Key()]
        public int Id { get; set; }
        public String PostText { get; set; }
        public String UserId { get; set; }
        public int RelatedId { get; set; }
        public DateTime? Created { get; set; }
        public String UserName { get; set; }
        public String UserProfilePic { get; set; }
    }
    public class Circle
    {
        public Circle()
        {
            this.Created = DateTime.Now;
        }
        [Key()]
        public int Id { get; set; }
        public String FullName { get; set; }
        public String CircleType { get; set; }
        public String Description { get; set; }
        public int ParentCircle { get; set; }
        public String Setting1 { get; set; }
        public String Setting2 { get; set; }
        public int IntSetting1 { get; set; }
        public DateTime? DateSetting { get; set; }
        public DateTime? Created { get; set; }
        public List<ZoneInfluencer> Influencers { get; set; }
        public List<ZoneIssue> Issues  { get; set; }
        public List<Voter>  voters { get; set; }

    }
   
    public class ZoneIssue
    {
        public int Id { get; set; }
        public int CircleId { get; set; }
        public String Bio { get; set; }
    }
    public class ZoneInfluencer
    {
        public int Id { get; set; }
        public int CircleId { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }
        public String Status { get; set; }
        public String Category { get; set; }
        public String ContactNumber { get; set; }
    }
    
}
