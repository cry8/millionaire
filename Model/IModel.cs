using System.Collections.Generic;

namespace Model
{
    public interface IModel
    {
        List<Questions> Elements { get; set; }
        void OpenConnection();
        void CloseConnection();
        IEnumerable<object[]> GetRow();
        void LoadData();
        void Delete(int index);
        void Add(string Text, string[] Answers);
        void Edit(int index, string Text, string[] Answers);
        Questions this[int index] { get; set; }
        int Count { get;}
    }
}
