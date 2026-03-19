using System;

namespace DocumentModel.Interop.Core;

public interface IBlogExtensibility
{
  void BlogProviderProperties
    (out string BlogProvider, out string FriendlyName, out MsoBlogCategorySupport CategorySupport, out bool Padding);

  void SetupBlogAccount(string Account, int ParentWindow, object Document, bool NewAccount, out bool ShowPictureUI);

  void GetUserBlogs
    (string Account, int ParentWindow, object Document, out Array BlogNames, out Array BlogIDs, out Array BlogURLs);

  void GetRecentPosts
    (string Account, int ParentWindow, object Document, out Array PostTitles, out Array PostDates, out Array PostIDs);

  void Open
  (string Account, string PostID, int ParentWindow, out string xHTML, out string Title, out string DatePosted,
    out Array Categories);

  void PublishPost
  (string Account, int ParentWindow, object Document, string xHTML, string Title, string DateTime, Array Categories,
    bool Draft, out string PostID, out string PublishMessage);

  void RepublishPost
  (string Account, int ParentWindow, object Document, string PostID, string xHTML, string Title, string DateTime,
    Array Categories, bool Draft, out string PublishMessage);

  void GetCategories(string Account, int ParentWindow, object Document, out Array Categories);
}