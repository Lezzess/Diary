using System;

namespace Application.Dtos
{
    public class DiaryEntryDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
