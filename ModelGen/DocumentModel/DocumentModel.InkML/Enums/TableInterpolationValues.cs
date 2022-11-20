namespace DocumentModel.InkML;

/// <summary>
/// Defines the TableInterpolationValues enumeration.
/// </summary>
public enum TableInterpolationValues
{
  /// <summary>
  /// floor.
  /// </summary>
  [XmlEnum("floor")]
  Floor,
  
  /// <summary>
  /// middle.
  /// </summary>
  [XmlEnum("middle")]
  Middle,
  
  /// <summary>
  /// ceiling.
  /// </summary>
  [XmlEnum("ceiling")]
  Ceiling,
  
  /// <summary>
  /// linear.
  /// </summary>
  [XmlEnum("linear")]
  Linear,
  
  /// <summary>
  /// cubic.
  /// </summary>
  [XmlEnum("cubic")]
  Cubic,
  
}
