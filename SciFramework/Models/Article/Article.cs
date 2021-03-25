using SciFramework.Abstract.Database;
using SciFramework.Interfaces.Article;

namespace SciFramework.Models.Article
{
    public class Article : Saveable, IArticle
    {
        private string _uid;
        private string _author;
        private string _header;
        private string _text;
        private string[] _commentsUID;
        public string UID => _uid;
        public string Author => _author;
        public string Header => _header;
        public string Text => _text;

        public string[] CommentsUID
        {
            get { return _commentsUID; }
            set { _commentsUID = value; }
        }
    }
}
