namespace DocumentModel.Math;
/// <summary>
///   Defines the ScriptValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.ScriptValues))]
public enum RunScript
{
  /// <summary>
  ///   Roman.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ScriptValues.Roman))]
  Roman,
  /// <summary>
  ///   Script.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ScriptValues.Script))]
  Script,
  /// <summary>
  ///   Fraktur.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ScriptValues.Fraktur))]
  Fraktur,
  /// <summary>
  ///   double-struck.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ScriptValues.DoubleStruck))]
  DoubleStruck,
  /// <summary>
  ///   Sans-Serif.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ScriptValues.SansSerif))]
  SansSerif,
  /// <summary>
  ///   Monospace.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ScriptValues.Monospace))]
  Monospace
}