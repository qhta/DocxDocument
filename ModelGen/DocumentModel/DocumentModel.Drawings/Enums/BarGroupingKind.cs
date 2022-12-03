namespace DocumentModel.Drawings;

/// <summary>
/// Bar Grouping
/// </summary>
public enum BarGroupingKind
{
  /// <summary>
  /// 100% Stacked.
  /// </summary>
  [XmlEnum("percentStacked")]
  PercentStacked,
  
  /// <summary>
  /// Clustered.
  /// </summary>
  [XmlEnum("clustered")]
  Clustered,
  
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
