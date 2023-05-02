namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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