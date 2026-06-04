namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of link.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLinkType))]
public enum LinkType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeOLE))]
  OLE = 0,
  /// <summary>
  /// Picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypePicture))]
  Picture = 1,
  /// <summary>
  /// Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeText))]
  Text = 2,
  /// <summary>
  /// Reference library.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeReference))]
  Reference = 3,
  /// <summary>
  /// Include file.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeInclude))]
  Include = 4,
  /// <summary>
  /// Import file.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeImport))]
  Import = 5,
  /// <summary>
  /// Dynamic Data Exchange.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeDDE))]
  DDE = 6,
  /// <summary>
  /// DDE automatic.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeDDEAuto))]
  DDEAuto = 7,
  /// <summary>
  /// Microsoft Excel chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLinkType.wdLinkTypeChart))]
  Chart = 8
}
