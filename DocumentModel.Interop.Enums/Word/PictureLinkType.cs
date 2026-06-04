namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a picture should be linked to a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpicturelinktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPictureLinkType))]
public enum PictureLinkType
{
  /// <summary>
  /// Do not link to or embed the picture in the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPictureLinkType.wdLinkNone))]
  None = 0,
  /// <summary>
  /// Embed the picture in the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPictureLinkType.wdLinkDataInDoc))]
  DataInDoc = 1,
  /// <summary>
  /// Link the picture to the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPictureLinkType.wdLinkDataOnDisk))]
  DataOnDisk = 2
}
