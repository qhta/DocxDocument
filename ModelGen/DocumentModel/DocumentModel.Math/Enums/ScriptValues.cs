namespace DocumentModel.Math;

/// <summary>
/// Defines the ScriptValues enumeration.
/// </summary>
public enum ScriptValues
{
  /// <summary>
  /// Roman.
  /// </summary>
  [XmlEnum("roman")]
  Roman,
  
  /// <summary>
  /// Script.
  /// </summary>
  [XmlEnum("script")]
  Script,
  
  /// <summary>
  /// Fraktur.
  /// </summary>
  [XmlEnum("fraktur")]
  Fraktur,
  
  /// <summary>
  /// double-struck.
  /// </summary>
  [XmlEnum("double-struck")]
  DoubleStruck,
  
  /// <summary>
  /// Sans-Serif.
  /// </summary>
  [XmlEnum("sans-serif")]
  SansSerif,
  
  /// <summary>
  /// Monospace.
  /// </summary>
  [XmlEnum("monospace")]
  Monospace,
  
}
