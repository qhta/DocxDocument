namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of list from a list template gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistgallerytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdListGalleryType")]
public enum ListGalleryType
{
  /// <summary>
  /// Bulleted list.
  /// </summary>
  [WordInteropEnumValue("wdBulletGallery")]
  BulletGallery = 1,
  /// <summary>
  /// Numbered list.
  /// </summary>
  [WordInteropEnumValue("wdNumberGallery")]
  NumberGallery = 2,
  /// <summary>
  /// Outline numbered list.
  /// </summary>
  [WordInteropEnumValue("wdOutlineNumberGallery")]
  OutlineNumberGallery = 3
}
