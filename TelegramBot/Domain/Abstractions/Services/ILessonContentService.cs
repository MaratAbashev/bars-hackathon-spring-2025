using Domain.Models.Dto.Admin;
using Domain.Utils;

namespace Domain.Abstractions.Services;

public interface ILessonContentService
{
    Task<Result<AdminLessonContentResponseDto>> AddLessonContent(Guid lessonId, string fileName, Stream fileStream, string contentType);
    Task<Result> AddLessonContentText(CreateLessonContentTextDto createLessonContentTextDto);
    Task<Result> RemoveLessonContent(Guid lessonContentId);
    Task<Result<List<AdminLessonContentResponseDto>>> GetAllLessonContents(Guid lessonId);
}