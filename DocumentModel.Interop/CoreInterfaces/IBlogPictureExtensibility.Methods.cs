
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IBlogPictureExtensibility` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IBlogPictureExtensibility
{
  /// <summary>
  /// Invokes `BlogPictureProviderProperties`.
  /// </summary>
  /// <param name="BlogPictureProvider">The `BlogPictureProvider` parameter.</param>
  /// <param name="FriendlyName">The `FriendlyName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.blogpictureproviderproperties?view=office-pia
  /// </remarks>
  public void BlogPictureProviderProperties(out string BlogPictureProvider, out string FriendlyName);
  /// <summary>
  /// Invokes `CreatePictureAccount`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="BlogProvider">The `BlogProvider` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.createpictureaccount?view=office-pia
  /// </remarks>
  public void CreatePictureAccount(string Account, string BlogProvider, int ParentWindow, object Document);
  /// <summary>
  /// Invokes `PublishPicture`.
  /// </summary>
  /// <param name="Account">The `Account` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="Document">The `Document` parameter.</param>
  /// <param name="Image">The `Image` parameter.</param>
  /// <param name="PictureURI">The `PictureURI` parameter.</param>
  /// <param name="ImageType">The `ImageType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iblogpictureextensibility.publishpicture?view=office-pia
  /// </remarks>
  public void PublishPicture
    (string Account, int ParentWindow, object Document, object Image, out string PictureURI, int ImageType);
}
