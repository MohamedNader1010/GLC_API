using AutoMapper;
using GLC.Core.Resources;
using GLC.Cores.Models;

namespace GLC.Core.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentResource>().ReverseMap();
            CreateMap<Group, GroupResource>().ReverseMap();
            CreateMap<Teacher, TeacherResource>().ReverseMap();
            CreateMap<GroupChat, GroupChatResource>().ReverseMap();
            CreateMap<ChattingDetails, ChattingDetailsResource>().ReverseMap();
            CreateMap<QuestionAnswer, QuestionAnswerResource>().ReverseMap();
            CreateMap<QuestionBank, QuestionBankResource>().ReverseMap();
            CreateMap<QuestionCategory, QuestionCategoryResource>().ReverseMap();
            CreateMap<Quiz, QuizResource>().ReverseMap();
            CreateMap<StudentQuizeQuestionBank, StudentQuizQuestionBankResource>().ReverseMap();
            CreateMap<Subject, SubjectResource>().ReverseMap();
            CreateMap<Video, VideoResource>().ReverseMap();

        }
    }
}
