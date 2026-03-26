namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of link.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinktype?view=office-pia` for Office interop details.
/// </remarks>
public enum LinkType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  OLE = 0,
  /// <summary>
  /// Picture.
  /// </summary>
  Picture = 1,
  /// <summary>
  /// Text.
  /// </summary>
  Text = 2,
  /// <summary>
  /// Reference library.
  /// </summary>
  Reference = 3,
  /// <summary>
  /// Include file.
  /// </summary>
  Include = 4,
  /// <summary>
  /// Import file.
  /// </summary>
  Import = 5,
  /// <summary>
  /// Dynamic Data Exchange.
  /// </summary>
  DDE = 6,
  /// <summary>
  /// DDE automatic.
  /// </summary>
  DDEAuto = 7,
  /// <summary>
  /// Microsoft Excel chart.
  /// </summary>
  Chart = 8
}
