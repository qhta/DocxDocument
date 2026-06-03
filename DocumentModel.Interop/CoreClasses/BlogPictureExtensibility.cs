
namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the ability to manipulate blog images.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility?view=office-pia"/>
public partial class BlogPictureExtensibility
{


  #region methods

/// <summary>
  /// Enables picture providers to offer themselves as an upload location for blog pictures.
  /// </summary>
  /// <param name="blogPictureProvider">The `BlogPictureProvider` parameter.</param>
  /// <param name="friendlyName">The `FriendlyName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.blogpictureproviderproperties?view=office-pia"/>
  public void BlogPictureProviderProperties(out string blogPictureProvider, out string friendlyName) { throw new NotImplementedException(); }
  /// <summary>
  /// Displays the UI needed to guide the user through picture account setup.
  /// </summary>
  /// <param name="account">The `Account` parameter.</param>
  /// <param name="blogProvider">The `BlogProvider` parameter.</param>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="document">The `Document` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.createpictureaccount?view=office-pia"/>
  public void CreatePictureAccount(string account, string blogProvider, int parentWindow, object document) { throw new NotImplementedException(); }
  /// <summary>
  /// Posts a picture object to its final destination in a blog.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="Image">The `Image` parameter.</param>
  /// <param name="PictureURI">The `PictureURI` parameter.</param>
  /// <param name="ImageType">The `ImageType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.publishpicture?view=office-pia"/>
  public void PublishPicture
    (string Account, int ParentWindow, object Document, object Image, out string PictureURI, int ImageType) { throw new NotImplementedException(); }

  #endregion methods
}


