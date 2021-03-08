using Core.Basis;

namespace Core.Entities
{
    public class DiaryEntry : AggregateRoot
    {
        #region Properties

        public string Title { get; }
        public string Description { get; }

        #endregion

        #region Constructors

        public DiaryEntry(string title, string description)
        {
            Title = title;
            Description = description;
        }

        #endregion
    }
}
