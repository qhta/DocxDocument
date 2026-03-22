namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a picture should be linked to a document.
/// </summary>
public enum WdPictureLinkType
{
  /// <summary>
  /// Do not link to or embed the picture in the document.
  /// </summary>
  wdLinkNone = unchecked((int)0),
  /// <summary>
  /// Embed the picture in the document.
  /// </summary>
  wdLinkDataInDoc = unchecked((int)1),
  /// <summary>
  /// Link the picture to the document.
  /// </summary>
  wdLinkDataOnDisk = unchecked((int)2)
}
