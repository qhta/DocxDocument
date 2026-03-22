namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of link.
/// </summary>
public enum WdLinkType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  wdLinkTypeOLE = unchecked((int)0),
  /// <summary>
  /// Picture.
  /// </summary>
  wdLinkTypePicture = unchecked((int)1),
  /// <summary>
  /// Text.
  /// </summary>
  wdLinkTypeText = unchecked((int)2),
  /// <summary>
  /// Reference library.
  /// </summary>
  wdLinkTypeReference = unchecked((int)3),
  /// <summary>
  /// Include file.
  /// </summary>
  wdLinkTypeInclude = unchecked((int)4),
  /// <summary>
  /// Import file.
  /// </summary>
  wdLinkTypeImport = unchecked((int)5),
  /// <summary>
  /// Dynamic Data Exchange.
  /// </summary>
  wdLinkTypeDDE = unchecked((int)6),
  /// <summary>
  /// DDE automatic.
  /// </summary>
  wdLinkTypeDDEAuto = unchecked((int)7),
  /// <summary>
  /// Microsoft Excel chart.
  /// </summary>
  wdLinkTypeChart = unchecked((int)8)
}
