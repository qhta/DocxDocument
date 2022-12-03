namespace DocumentModel.Drawings;

/// <summary>
/// Grouping
/// </summary>
public enum GroupingKind
{
  /// <summary>
  /// 100% Stacked.
  /// </summary>
  [XmlEnum("percentStacked")]
  PercentStacked,
  
  /// <summary>
  /// Standard.
  /// </summary>
  [XmlEnum("standard")]
  Standard,
  
  /// <summary>
  /// Stacked.
  /// </summary>
  [XmlEnum("stacked")]
  Stacked,
  
}
