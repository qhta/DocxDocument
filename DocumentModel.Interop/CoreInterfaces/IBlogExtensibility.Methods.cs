using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IBlogExtensibility` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IBlogExtensibility
{
  /// <summary>
  /// Invokes `BlogProviderProperties`.
  /// </summary>
  /// <param name="BlogProvider">The `BlogProvider` parameter.</param>
  /// <param name="FriendlyName">The `FriendlyName` parameter.</param>
  /// <param name="CategorySupport">The `CategorySupport` parameter.</param>
  /// <param name="Padding">The `Padding` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.blogproviderproperties?view=office-pia
  /// </remarks>
  public void BlogProviderProperties
    (out string BlogProvider, out string FriendlyName, out MsoBlogCategorySupport CategorySupport, out bool Padding);
  /// <summary>
  /// Invokes `SetupBlogAccount`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="NewAccount">The `NewAccount` parameter.</param>
  /// <param name="ShowPictureUI">The `ShowPictureUI` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.setupblogaccount?view=office-pia
  /// </remarks>
  public void SetupBlogAccount(string Account, int ParentWindow, object Document, bool NewAccount, out bool ShowPictureUI);
  /// <summary>
  /// Invokes `GetUserBlogs`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="BlogNames">The `BlogNames` parameter.</param>
  /// <param name="BlogIDs">The `BlogIDs` parameter.</param>
  /// <param name="BlogURLs">The `BlogURLs` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.getuserblogs?view=office-pia
  /// </remarks>
  public void GetUserBlogs
    (string Account, int ParentWindow, object Document, out Array BlogNames, out Array BlogIDs, out Array BlogURLs);
  /// <summary>
  /// Invokes `GetRecentPosts`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="PostTitles">The `PostTitles` parameter.</param>
  /// <param name="PostDates">The `PostDates` parameter.</param>
  /// <param name="PostIDs">The `PostIDs` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.getrecentposts?view=office-pia
  /// </remarks>
  public void GetRecentPosts
    (string Account, int ParentWindow, object Document, out Array PostTitles, out Array PostDates, out Array PostIDs);
  /// <summary>
  /// Invokes `Open`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="PostID">The `PostID` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="xHTML">The `xHTML` parameter.</param>
  /// <param name="Title">The `Title` parameter.</param>
  /// <param name="DatePosted">The `DatePosted` parameter.</param>
  /// <param name="Categories">The `Categories` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.open?view=office-pia
  /// </remarks>
  public void Open
  (string Account, string PostID, int ParentWindow, out string xHTML, out string Title, out string DatePosted,
    out Array Categories);
  /// <summary>
  /// Invokes `PublishPost`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="xHTML">The `xHTML` parameter.</param>
  /// <param name="Title">The `Title` parameter.</param>
  /// <param name="DateTime">The `DateTime` parameter.</param>
  /// <param name="Categories">The `Categories` parameter.</param>
  /// <param name="Draft">The `Draft` parameter.</param>
  /// <param name="PostID">The `PostID` parameter.</param>
  /// <param name="PublishMessage">The `PublishMessage` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.publishpost?view=office-pia
  /// </remarks>
  public void PublishPost
  (string Account, int ParentWindow, object Document, string xHTML, string Title, string DateTime, Array Categories,
    bool Draft, out string PostID, out string PublishMessage);
  /// <summary>
  /// Invokes `RepublishPost`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="PostID">The `PostID` parameter.</param>
  /// <param name="xHTML">The `xHTML` parameter.</param>
  /// <param name="Title">The `Title` parameter.</param>
  /// <param name="DateTime">The `DateTime` parameter.</param>
  /// <param name="Categories">The `Categories` parameter.</param>
  /// <param name="Draft">The `Draft` parameter.</param>
  /// <param name="PublishMessage">The `PublishMessage` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.republishpost?view=office-pia
  /// </remarks>
  public void RepublishPost
  (string Account, int ParentWindow, object Document, string PostID, string xHTML, string Title, string DateTime,
    Array Categories, bool Draft, out string PublishMessage);
  /// <summary>
  /// Invokes `GetCategories`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="Categories">The `Categories` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.getcategories?view=office-pia
  /// </remarks>
  public void GetCategories(string Account, int ParentWindow, object Document, out Array Categories);
}
