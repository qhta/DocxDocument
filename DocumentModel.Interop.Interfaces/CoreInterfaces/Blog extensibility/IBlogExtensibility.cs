namespace DocumentModel.Interop.Core;

/// <summary>
/// Microsoft Word's blog extensibility refers to the built-in integrations and developer interfaces that allow the word processor to communicate directly with external blogging platforms and content management systems (CMS) like WordPress or SharePoint.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility?view=office-pia"/>
public interface IBlogExtensibility
{
  #region methods

/// <summary>
  /// Contains information about the blog provider.
  /// </summary>
  /// <param name="BlogProvider">The `BlogProvider` parameter.</param>
  /// <param name="FriendlyName">The `FriendlyName` parameter.</param>
  /// <param name="CategorySupport">The `CategorySupport` parameter.</param>
  /// <param name="Padding">The `Padding` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.blogproviderproperties?view=office-pia"/>
  public void BlogProviderProperties
    (out string BlogProvider, out string FriendlyName, out BlogCategorySupport CategorySupport, out bool Padding);
  /// <summary>
  /// Sets up a provider account from the account selection dialogs.
  /// </summary>
  /// <param name="account">The `Account` parameter.</param>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="document">The `Document` parameter.</param>
  /// <param name="newAccount">The `NewAccount` parameter.</param>
  /// <param name="showPictureUI">The `ShowPictureUI` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.setupblogaccount?view=office-pia"/>
  public void SetupBlogAccount(string account, int parentWindow, object document, bool newAccount, out bool showPictureUI);
  /// <summary>
  /// Returns the list and details of user blogs associated with the specified account.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="BlogNames">The `BlogNames` parameter.</param>
  /// <param name="BlogIDs">The `BlogIDs` parameter.</param>
  /// <param name="BlogURLs">The `BlogURLs` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.getuserblogs?view=office-pia"/>
  public void GetUserBlogs
    (string Account, int ParentWindow, object Document, out Array BlogNames, out Array BlogIDs, out Array BlogURLs);
  /// <summary>
  /// Returns recent blog posts for display in the Open Existing Post dialog.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="PostTitles">The `PostTitles` parameter.</param>
  /// <param name="PostDates">The `PostDates` parameter.</param>
  /// <param name="PostIDs">The `PostIDs` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.getrecentposts?view=office-pia"/>
  public void GetRecentPosts
    (string Account, int ParentWindow, object Document, out Array PostTitles, out Array PostDates, out Array PostIDs);
  /// <summary>
  /// Opens the blog post specified by the post identifier.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="PostID">The `PostID` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="xHTML">The `xHTML` parameter.</param>
  /// <param name="Title">The `Title` parameter.</param>
  /// <param name="DatePosted">The `DatePosted` parameter.</param>
  /// <param name="Categories">The `Categories` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.open?view=office-pia"/>
  public void Open
  (string Account, string PostID, int ParentWindow, out string xHTML, out string Title, out string DatePosted,
    out Array Categories);
  /// <summary>
  /// Hands off the current post so it can be published by the provider.
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.publishpost?view=office-pia"/>
  public void PublishPost
  (string Account, int ParentWindow, object Document, string xHTML, string Title, string DateTime, Array Categories,
    bool Draft, out string PostID, out string PublishMessage);
  /// <summary>
  /// Hands off an existing post so it can be republished by the provider.
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.republishpost?view=office-pia"/>
  public void RepublishPost
  (string Account, int ParentWindow, object Document, string PostID, string xHTML, string Title, string DateTime,
    Array Categories, bool Draft, out string PublishMessage);
  /// <summary>
  /// Returns the list of blog categories for an account.
  /// </summary>
  /// <param name="account">The `Account` parameter.</param>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="document">The `Document` parameter.</param>
  /// <param name="categories">The `Categories` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogextensibility.getcategories?view=office-pia"/>
  public void GetCategories(string account, int parentWindow, object document, out Array categories);

  #endregion methods
}

