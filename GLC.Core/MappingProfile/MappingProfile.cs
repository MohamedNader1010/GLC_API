using AutoMapper;
using GLC.Core.Resources;
using GLC.Cores.Models;

namespace GLC.Core.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentResource>().ReverseMap().ForMember(n => n.StudentId, m => m.Ignore());
            CreateMap<Group, GroupResource>().ReverseMap().ForMember(n => n.GroupId, m => m.Ignore());
            CreateMap<Teacher, TeacherResource>().ReverseMap().ForMember(n=>n.TeacherId,m=>m.Ignore());
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
