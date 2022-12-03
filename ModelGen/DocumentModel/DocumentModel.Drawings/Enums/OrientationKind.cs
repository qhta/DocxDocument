namespace DocumentModel.Drawings;

/// <summary>
/// Orientation
/// </summary>
public enum OrientationKind
{
  /// <summary>
  /// Maximum to Minimum.
  /// </summary>
  [XmlEnum("maxMin")]
  MaxMin,
  
  /// <summary>
  /// Minimum to Maximum.
  /// </summary>
  [XmlEnum("minMax")]
  MinMax,
  
}
