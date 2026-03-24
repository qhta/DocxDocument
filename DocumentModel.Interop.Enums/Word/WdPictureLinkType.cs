namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a picture should be linked to a document.
/// </summary>
public enum WdPictureLinkType
{
  /// <summary>
  /// Do not link to or embed the picture in the document.
  /// </summary>
  None = 0,
  /// <summary>
  /// Embed the picture in the document.
  /// </summary>
  DataInDoc = 1,
  /// <summary>
  /// Link the picture to the document.
  /// </summary>
  DataOnDisk = 2
}
