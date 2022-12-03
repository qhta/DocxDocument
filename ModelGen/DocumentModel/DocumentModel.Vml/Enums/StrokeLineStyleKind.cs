namespace DocumentModel.Vml;

/// <summary>
/// Stroke Line Style
/// </summary>
public enum StrokeLineStyleKind
{
  /// <summary>
  /// Single Line.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// Two Thin Lines.
  /// </summary>
  [XmlEnum("thinThin")]
  ThinThin,
  
  /// <summary>
  /// Thin Line Outside Thick Line.
  /// </summary>
  [XmlEnum("thinThick")]
  ThinThick,
  
  /// <summary>
  /// Thick Line Outside Thin Line.
  /// </summary>
  [XmlEnum("thickThin")]
  ThickThin,
  
  /// <summary>
  /// Thck Line Between Thin Lines.
  /// </summary>
  [XmlEnum("thickBetweenThin")]
  ThickBetweenThin,
  
}
