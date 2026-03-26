namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a picture should be linked to a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpicturelinktype?view=office-pia` for Office interop details.
/// </remarks>
public enum PictureLinkType
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
