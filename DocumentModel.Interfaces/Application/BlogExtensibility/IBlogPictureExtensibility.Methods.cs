
namespace DocumentModel.Application;

/// <summary>
/// Provides the ability to manipulate blog images.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility?view=office-pia"/>
public partial interface IBlogPictureExtensibility: InteropObject
{
  /// <summary>
  /// Enables picture providers to offer themselves as an upload location for blog pictures.
  /// </summary>
  /// <param name="BlogPictureProvider">The `BlogPictureProvider` parameter.</param>
  /// <param name="FriendlyName">The `FriendlyName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.blogpictureproviderproperties?view=office-pia"/>
  public void BlogPictureProviderProperties(out string BlogPictureProvider, out string FriendlyName);
  /// <summary>
  /// Displays the UI needed to guide the user through picture account setup.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="BlogProvider">The `BlogProvider` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.createpictureaccount?view=office-pia"/>
  public void CreatePictureAccount(string Account, string BlogProvider, int ParentWindow, object Document);
  /// <summary>
  /// Posts a picture object to its final destination in a blog.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="Image">The `Image` parameter.</param>
  /// <param name="PictureURI">The `PictureURI` parameter.</param>
  /// <param name="ImageType">The `ImageType` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.publishpicture?view=office-pia"/>
  public void PublishPicture
    (string Account, int ParentWindow, object Document, object Image, out string PictureURI, int ImageType);
}

