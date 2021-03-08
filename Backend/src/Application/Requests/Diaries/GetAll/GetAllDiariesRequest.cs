using System.Collections.Generic;
using Application.Dtos;
using MediatR;

namespace Application.Requests.Diaries.GetAll
{
    public class GetAllDiariesRequest : IRequest<List<DiaryEntryDto>>
    {

    }
}
