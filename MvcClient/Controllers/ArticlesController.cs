using MvcClient.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcClient.Controllers
{
    public class ArticlesController : ApiController
    {
      private MvcClientContext db = new MvcClientContext();

      public IEnumerable<Article> GetArticlesByCategory(CategoryEnum id)
      {
        var articles = db.Articles
            .Where(a => a.Category == id)
            .OrderBy(a => a.Published);
        return articles;
      }
    }
}
