namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceTypeValues enumeration.
/// </summary>
public enum TraceTypeValues
{
  /// <summary>
  /// penDown.
  /// </summary>
  [XmlEnum("penDown")]
  PenDown,
  
  /// <summary>
  /// penUp.
  /// </summary>
  [XmlEnum("penUp")]
  PenUp,
  
  /// <summary>
  /// indeterminate.
  /// </summary>
  [XmlEnum("indeterminate")]
  Indeterminate,
  
}
