namespace Domain.Entities;

public class UserAnsweredQuestionEntity
{
    public long UserId { get; set; }
    public UserEntity User { get; set; }

    public Guid? QuestionId { get; set; }
    public QuizQuestionEntity Question { get; set; }

    public bool IsRight { get; set; }
}