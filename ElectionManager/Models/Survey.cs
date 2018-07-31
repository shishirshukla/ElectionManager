using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ElectionManager.Models
{
    
        public class Question
        {
            [Key()]
            public int Id { get; set; }
            public int SurveyId { get; set; }
            public String QuestionText { get; set; }
            public String QuestionValidProfile { get; set; }
            public String QuestionNotValidProfile { get; set; }
            public int QuestionInfo3 { get; set; }
            public int QuestionInfo4 { get; set; }
            public String QuestionStatus { get; set; }
            public DateTime? DateSetting { get; set; }
            public DateTime? Created { get; set; }
            public List<Option> Options { get; set; }
    }
        
        public class Option
        {

            public int Id { get; set; }
            public int QuestionId { get; set; }
            public int MoveToQuestionId { get; set; }     
            public String OptionText { get; set; }
            
            public bool isAnswered { get; set; }
            public bool isCorrect { get; set; }
        }
        public class Survey
        {
            public Survey()
            {
                Created = DateTime.Now;
            }
            [Key()]
            public int Id { get; set; }
            public String SurveyName { get; set; }
            public int UserId { get; set; }
            public String StrSetting1 { get; set; }
            public int IntSetting1 { get; set; }
            public int IntSetting2 { get; set; }
            public String StrSetting2 { get; set; }
            public DateTime? ValidToDate { get; set; }
            public DateTime? ValidFromDate { get; set; }
            public DateTime? Created { get; set; }
            public List<Question> Questions { get; set; }

    }
       public class SurveyInCircle
        {
        public SurveyInCircle()
        {
            Created = DateTime.Now;
        }
            [Key()]
            public int Id { get; set; }
            public int SurveyId { get; set; }
            public int CircleId { get; set; }
            public String Setting1 { get; set; }
            public String Setting2 { get; set; }
            public int IntSetting1 { get; set; }
            public DateTime? DateSetting { get; set; }
            public DateTime? Created { get; set; }

        }
       
        public class QuestionResponse
        {
            [Key()]
            public int Id { get; set; }
            public String ResponseId { get; set; }
            public int SurveyId { get; set; }
            public int QuestionId { get; set; }
            public int OptionId { get; set; }
            public String Response { get; set; }
            public String GeoLocation { get; set; }
            public String EpicNumber { get; set; }
            public String ResponserName { get; set; }
            public String ResponserNumber   { get; set; }
            public String ResponserProfile { get; set; }
            public int CircleId { get; set; }
            public int UserId { get; set; }
            public String Setting1 { get; set; }
            public int IntSetting1 { get; set; }
            public DateTime? DateSetting { get; set; }
            public DateTime? Created { get; set; }

        }
        
    }

