namespace DocumentModel.Math;

/// <summary>
/// Defines the FractionTypeValues enumeration.
/// </summary>
public enum FractionType
{
  /// <summary>
  /// Bar Fraction.
  /// </summary>
  [XmlEnum("bar")]
  Bar,
  
  /// <summary>
  /// Skewed.
  /// </summary>
  [XmlEnum("skw")]
  Skewed,
  
  /// <summary>
  /// Linear Fraction.
  /// </summary>
  [XmlEnum("lin")]
  Linear,
  
  /// <summary>
  /// No-Bar Fraction (Stack).
  /// </summary>
  [XmlEnum("noBar")]
  NoBar,
  
}
