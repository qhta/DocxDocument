namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of link.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLinkType")]
public enum LinkType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeOLE")]
  OLE = 0,
  /// <summary>
  /// Picture.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypePicture")]
  Picture = 1,
  /// <summary>
  /// Text.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeText")]
  Text = 2,
  /// <summary>
  /// Reference library.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeReference")]
  Reference = 3,
  /// <summary>
  /// Include file.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeInclude")]
  Include = 4,
  /// <summary>
  /// Import file.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeImport")]
  Import = 5,
  /// <summary>
  /// Dynamic Data Exchange.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeDDE")]
  DDE = 6,
  /// <summary>
  /// DDE automatic.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeDDEAuto")]
  DDEAuto = 7,
  /// <summary>
  /// Microsoft Excel chart.
  /// </summary>
  [WordInteropEnumValue("wdLinkTypeChart")]
  Chart = 8
}
