namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Grouping
/// </summary>
public enum Grouping
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
