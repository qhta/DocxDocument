namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthUnitValues enumeration.
/// </summary>
public enum TableWidthUnitKind
{
  /// <summary>
  /// No Width.
  /// </summary>
  [XmlEnum("nil")]
  Nil,
  
  /// <summary>
  /// Width in Fiftieths of a Percent.
  /// </summary>
  [XmlEnum("pct")]
  Pct,
  
  /// <summary>
  /// Width in Twentieths of a Point.
  /// </summary>
  [XmlEnum("dxa")]
  Dxa,
  
  /// <summary>
  /// Automatically Determined Width.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
}
