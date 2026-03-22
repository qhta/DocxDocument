namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of list from a list template gallery.
/// </summary>
public enum WdListGalleryType
{
  /// <summary>
  /// Bulleted list.
  /// </summary>
  wdBulletGallery = unchecked((int)1),
  /// <summary>
  /// Numbered list.
  /// </summary>
  wdNumberGallery = unchecked((int)2),
  /// <summary>
  /// Outline numbered list.
  /// </summary>
  wdOutlineNumberGallery = unchecked((int)3)
}
