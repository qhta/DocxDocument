namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort By
/// </summary>
public enum SortBy
{
  /// <summary>
  /// Value.
  /// </summary>
  [XmlEnum("value")]
  Value,
  
  /// <summary>
  /// Sort by Cell Color.
  /// </summary>
  [XmlEnum("cellColor")]
  CellColor,
  
  /// <summary>
  /// Sort by Font Color.
  /// </summary>
  [XmlEnum("fontColor")]
  FontColor,
  
  /// <summary>
  /// Sort by Icon.
  /// </summary>
  [XmlEnum("icon")]
  Icon,
  
}
