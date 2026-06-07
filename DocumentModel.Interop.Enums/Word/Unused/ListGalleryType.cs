namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of list from a list template gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistgallerytype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdListGalleryType")]
public enum ListGalleryType
{
  /// <summary>
  /// Bulleted list.
  /// </summary>
  [InteropEnumValue("wdBulletGallery")]
  BulletGallery = 1,
  /// <summary>
  /// Numbered list.
  /// </summary>
  [InteropEnumValue("wdNumberGallery")]
  NumberGallery = 2,
  /// <summary>
  /// Outline numbered list.
  /// </summary>
  [InteropEnumValue("wdOutlineNumberGallery")]
  OutlineNumberGallery = 3
}
