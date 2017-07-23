using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcClient.Models
{
  public class MvcClientInitializer : DropCreateDatabaseAlways<MvcClientContext>
  {
    protected override void Seed(MvcClientContext context)
    {
      var article = new Article
      {
        Url = "http://www.buildinsider.net/web/jquerymobileref",
        Title = "jQuery Mobile逆引きリファレンス",
        Category = CategoryEnum.Reference,
        Description = "jQuery Mobileの基本機能を目的別リファレンスの形式でまとめます。",
        Viewcount = 36452,
        Published = DateTime.Parse("2014-01-09"),
        Released = true
      };
      context.Articles.Add(article);

      var article2 = new Article
      {
        Url = "http://codezine.jp/article/corner/518",
        Title = "Bootstrapでレスポンシブでリッチなサイトを構築",
        Category = CategoryEnum.DotNet,
        Description = "ASP.NET MVC5のひな形ページで使用されているBootstrapというフレームワークについて紹介します。",
        Viewcount = 9312,
        Published = DateTime.Parse("2014-05-22"),
        Released = true
      };
      context.Articles.Add(article2);

      var article3 = new Article
      {
        Url = "http://codezine.jp/article/corner/511",
        Title = "ASP.NET Identity入門",
        Category = CategoryEnum.DotNet,
        Description = "新しい認証、資格管理システムである「ASP.NET Identity」について、どのように使うのか、どんな仕組みで動いているのかを紹介していきます。",
        Viewcount = 8046,
        Published = DateTime.Parse("2014-04-25"),
        Released = true
      };
      context.Articles.Add(article3);

      var article4 = new Article
      {
        Url = "http://codezine.jp/article/corner/513",
        Title = "Amazon Web Servicesによるクラウド超入門",
        Category = CategoryEnum.Cloud,
        Description = "Amazon Web Servicesを使ってクラウドシステム上に簡単なWebシステムを構築していきます。",
        Viewcount = 25687,
        Published = DateTime.Parse("2014-04-25"),
        Released = true
      };
      context.Articles.Add(article4);


      var article5 = new Article
      {
        Url = "http://www.buildinsider.net/web/jqueryuiref",
        Title = "jQuery UI逆引きリファレンス",
        Category = CategoryEnum.Reference,
        Description = "jQuery UIの基本機能を目的別リファレンスの形式でまとめます。",
        Viewcount = 56710,
        Published = DateTime.Parse("2013-07-11"),
        Released = true
      };
      context.Articles.Add(article5);

      var article6 = new Article
      {
        Url = "http://www.wings.msn.to/mvc5",
        Title = "ASP.NET MVC 入門",
        Category = CategoryEnum.DotNet,
        Description = "ASP.NET MVCをこれから始める人のために、詳しく丁寧に段階を追って解説します。",
        Viewcount = 0,
        Published = DateTime.Parse("2015-01-20"),
        Released = false
      };
      context.Articles.Add(article6);

      var article7 = new Article
      {
        Url = "http://www.wings.msn.to/azure",
        Title = "Azure新機能TIPS",
        Category = CategoryEnum.Cloud,
        Description = "Microsoft Azureの新機能についてTIPS形式で、使い方などを解説します。",
        Viewcount = 13469,
        Published = DateTime.Parse("2014-04-25"),
        Released = true
      };
      context.Articles.Add(article7);
      
      var members = new List<Member> {
        new Member {
          Name = "山田リオ",
          Email = "rio@wings.msn.to",
          Birth = DateTime.Parse("1980-06-25"),
          Married = false,
          Memo = "ピアノが大好きです。"
        },
        new Member {
          Name = "日尾直弘",
          Email = "naohiro@wings.msn.to",
          Birth = DateTime.Parse("1975-07-19"),
          Married = false,
          Memo = "子どもにもやさしいお医者さんです。"
        },
        new Member {
          Name = "掛谷奈美",
          Email = "nami@wings.msn.to",
          Birth = DateTime.Parse("1985-08-05"),
          Married = false,
          Memo = "フラワーアレンジメントを勉強中です。"
        },
        new Member {
          Name = "木村次郎",
          Email = "jiro@wings.msn.to",
          Birth = DateTime.Parse("1970-12-15"),
          Married = true,
          Memo = "山登りが趣味です。休日は、よく山へ出かけます。"
        },
        new Member {
          Name = "鈴木恵子",
          Email = "keiko@wings.msn.to",
          Birth = DateTime.Parse("1984-11-23"),
          Married = true,
          Memo = "子どもと一緒にアニメを見るのが大好きです。"
        }
      };
      members.ForEach(m => context.Members.Add(m));
      context.SaveChanges();
    }
  }
}