namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Grouping
/// </summary>
public enum BarGrouping
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
