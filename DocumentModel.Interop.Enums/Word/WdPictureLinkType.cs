namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a picture should be linked to a document.
/// </summary>
public enum WdPictureLinkType
{
  /// <summary>
  /// Do not link to or embed the picture in the document.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Embed the picture in the document.
  /// </summary>
  DataInDoc = unchecked((int)1),
  /// <summary>
  /// Link the picture to the document.
  /// </summary>
  DataOnDisk = unchecked((int)2)
}
