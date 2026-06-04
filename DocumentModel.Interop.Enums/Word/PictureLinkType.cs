namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a picture should be linked to a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpicturelinktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPictureLinkType")]
public enum PictureLinkType
{
  /// <summary>
  /// Do not link to or embed the picture in the document.
  /// </summary>
  [WordInteropEnumValue("wdLinkNone")]
  None = 0,
  /// <summary>
  /// Embed the picture in the document.
  /// </summary>
  [WordInteropEnumValue("wdLinkDataInDoc")]
  DataInDoc = 1,
  /// <summary>
  /// Link the picture to the document.
  /// </summary>
  [WordInteropEnumValue("wdLinkDataOnDisk")]
  DataOnDisk = 2
}
