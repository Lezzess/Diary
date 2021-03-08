using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Persistence.ApplicationContext;

namespace Persistence.Services
{
    internal class DiaryRepository : IDiaryRepository
    {
        #region Public Methods

        public Task<List<DiaryEntry>> GetAllAsync()
        {
            var diaries = ApplicationContextMock.Diaries;
            return Task.FromResult(diaries);
        }

        #endregion
    }
}
