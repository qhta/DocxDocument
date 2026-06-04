namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of link.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinktype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLinkType")]
public enum LinkType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  [InteropEnumValue("wdLinkTypeOLE")]
  OLE = 0,
  /// <summary>
  /// Picture.
  /// </summary>
  [InteropEnumValue("wdLinkTypePicture")]
  Picture = 1,
  /// <summary>
  /// Text.
  /// </summary>
  [InteropEnumValue("wdLinkTypeText")]
  Text = 2,
  /// <summary>
  /// Reference library.
  /// </summary>
  [InteropEnumValue("wdLinkTypeReference")]
  Reference = 3,
  /// <summary>
  /// Include file.
  /// </summary>
  [InteropEnumValue("wdLinkTypeInclude")]
  Include = 4,
  /// <summary>
  /// Import file.
  /// </summary>
  [InteropEnumValue("wdLinkTypeImport")]
  Import = 5,
  /// <summary>
  /// Dynamic Data Exchange.
  /// </summary>
  [InteropEnumValue("wdLinkTypeDDE")]
  DDE = 6,
  /// <summary>
  /// DDE automatic.
  /// </summary>
  [InteropEnumValue("wdLinkTypeDDEAuto")]
  DDEAuto = 7,
  /// <summary>
  /// Microsoft Excel chart.
  /// </summary>
  [InteropEnumValue("wdLinkTypeChart")]
  Chart = 8
}
