namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of list from a list template gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistgallerytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdListGalleryType))]
public enum ListGalleryType
{
  /// <summary>
  /// Bulleted list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListGalleryType.wdBulletGallery))]
  BulletGallery = 1,
  /// <summary>
  /// Numbered list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListGalleryType.wdNumberGallery))]
  NumberGallery = 2,
  /// <summary>
  /// Outline numbered list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListGalleryType.wdOutlineNumberGallery))]
  OutlineNumberGallery = 3
}
