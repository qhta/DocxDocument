namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of list from a list template gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistgallerytype?view=office-pia` for Office interop details.
/// </remarks>
public enum ListGalleryType
{
  /// <summary>
  /// Bulleted list.
  /// </summary>
  BulletGallery = 1,
  /// <summary>
  /// Numbered list.
  /// </summary>
  NumberGallery = 2,
  /// <summary>
  /// Outline numbered list.
  /// </summary>
  OutlineNumberGallery = 3
}
