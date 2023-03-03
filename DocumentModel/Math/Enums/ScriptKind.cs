namespace DocumentModel.Math;

/// <summary>
///   Defines the ScriptValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ScriptKind
{
  /// <summary>
  ///   Roman.
  /// </summary>
  Roman,

  /// <summary>
  ///   Script.
  /// </summary>
  Script,

  /// <summary>
  ///   Fraktur.
  /// </summary>
  Fraktur,

  /// <summary>
  ///   double-struck.
  /// </summary>
  DoubleStruck,

  /// <summary>
  ///   Sans-Serif.
  /// </summary>
  SansSerif,

  /// <summary>
  ///   Monospace.
  /// </summary>
  Monospace
}