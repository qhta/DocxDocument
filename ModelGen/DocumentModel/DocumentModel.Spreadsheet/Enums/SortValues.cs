namespace DocumentModel.Spreadsheet;

/// <summary>
/// Set Sort Order
/// </summary>
public enum SortValues
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Ascending.
  /// </summary>
  [XmlEnum("ascending")]
  Ascending,
  
  /// <summary>
  /// Descending.
  /// </summary>
  [XmlEnum("descending")]
  Descending,
  
  /// <summary>
  /// Ascending Alpha.
  /// </summary>
  [XmlEnum("ascendingAlpha")]
  AscendingAlpha,
  
  /// <summary>
  /// Alphabetic Order Descending.
  /// </summary>
  [XmlEnum("descendingAlpha")]
  DescendingAlpha,
  
  /// <summary>
  /// Ascending Natural.
  /// </summary>
  [XmlEnum("ascendingNatural")]
  AscendingNatural,
  
  /// <summary>
  /// Natural Order Descending.
  /// </summary>
  [XmlEnum("descendingNatural")]
  DescendingNatural,
  
}
