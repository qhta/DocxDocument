using System;

namespace DocumentModel.Interop.Core;

public interface IBlogExtensibility
{
  public void BlogProviderProperties
    (out string BlogProvider, out string FriendlyName, out MsoBlogCategorySupport CategorySupport, out bool Padding);

  public void SetupBlogAccount(string Account, int ParentWindow, object Document, bool NewAccount, out bool ShowPictureUI);

  public void GetUserBlogs
    (string Account, int ParentWindow, object Document, out Array BlogNames, out Array BlogIDs, out Array BlogURLs);

  public void GetRecentPosts
    (string Account, int ParentWindow, object Document, out Array PostTitles, out Array PostDates, out Array PostIDs);

  public void Open
  (string Account, string PostID, int ParentWindow, out string xHTML, out string Title, out string DatePosted,
    out Array Categories);

  public void PublishPost
  (string Account, int ParentWindow, object Document, string xHTML, string Title, string DateTime, Array Categories,
    bool Draft, out string PostID, out string PublishMessage);

  public void RepublishPost
  (string Account, int ParentWindow, object Document, string PostID, string xHTML, string Title, string DateTime,
    Array Categories, bool Draft, out string PublishMessage);

  public void GetCategories(string Account, int ParentWindow, object Document, out Array Categories);
}
