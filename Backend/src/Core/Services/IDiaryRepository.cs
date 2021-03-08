﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Services
{
    public interface IDiaryRepository
    {
        Task<List<DiaryEntry>> GetAllAsync();
    }
}
