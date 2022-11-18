namespace DocumentModel.Spreadsheet;

/// <summary>
/// MDX Set Order
/// </summary>
public enum MdxSetOrder
{
  /// <summary>
  /// Unsorted.
  /// </summary>
  [XmlEnum("u")]
  Unsorted,
  
  /// <summary>
  /// Ascending.
  /// </summary>
  [XmlEnum("a")]
  Ascending,
  
  /// <summary>
  /// Descending.
  /// </summary>
  [XmlEnum("d")]
  Descending,
  
  /// <summary>
  /// Alpha Ascending Sort Order.
  /// </summary>
  [XmlEnum("aa")]
  AlphaAscendingSortOrder,
  
  /// <summary>
  /// Alpha Descending Sort Order.
  /// </summary>
  [XmlEnum("ad")]
  AlphaDescendingSortOrder,
  
  /// <summary>
  /// Natural Ascending.
  /// </summary>
  [XmlEnum("na")]
  NaturalAscending,
  
  /// <summary>
  /// Natural Descending.
  /// </summary>
  [XmlEnum("nd")]
  NaturalDescending,
  
}
