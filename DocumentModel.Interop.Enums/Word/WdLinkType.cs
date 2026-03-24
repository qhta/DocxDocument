namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of link.
/// </summary>
public enum WdLinkType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  OLE = unchecked((int)0),
  /// <summary>
  /// Picture.
  /// </summary>
  Picture = unchecked((int)1),
  /// <summary>
  /// Text.
  /// </summary>
  Text = unchecked((int)2),
  /// <summary>
  /// Reference library.
  /// </summary>
  Reference = unchecked((int)3),
  /// <summary>
  /// Include file.
  /// </summary>
  Include = unchecked((int)4),
  /// <summary>
  /// Import file.
  /// </summary>
  Import = unchecked((int)5),
  /// <summary>
  /// Dynamic Data Exchange.
  /// </summary>
  DDE = unchecked((int)6),
  /// <summary>
  /// DDE automatic.
  /// </summary>
  DDEAuto = unchecked((int)7),
  /// <summary>
  /// Microsoft Excel chart.
  /// </summary>
  Chart = unchecked((int)8)
}
