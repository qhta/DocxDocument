namespace DocumentModel.Math;

/// <summary>
/// Defines the BreakBinarySubtractionValues enumeration.
/// </summary>
public enum BreakBinarySubtractionKind
{
  /// <summary>
  /// Minus Minus.
  /// </summary>
  [XmlEnum("--")]
  MinusMinus,
  
  /// <summary>
  /// Minus Plus.
  /// </summary>
  [XmlEnum("-+")]
  MinusPlus,
  
  /// <summary>
  /// Plus Minus.
  /// </summary>
  [XmlEnum("+-")]
  PlusMinus,
  
}
