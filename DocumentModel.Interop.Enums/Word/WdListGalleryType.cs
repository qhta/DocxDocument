namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of list from a list template gallery.
/// </summary>
public enum WdListGalleryType
{
  /// <summary>
  /// Bulleted list.
  /// </summary>
  BulletGallery = unchecked((int)1),
  /// <summary>
  /// Numbered list.
  /// </summary>
  NumberGallery = unchecked((int)2),
  /// <summary>
  /// Outline numbered list.
  /// </summary>
  OutlineNumberGallery = unchecked((int)3)
}
