using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciFramework.Interfaces.Article
{
    public interface IArticle
    {
        string UID { get; }
        string Author { get; }
        string Header { get; }
        string Text { get; }
        string[] CommentsUID { get; set; }
    }
}
