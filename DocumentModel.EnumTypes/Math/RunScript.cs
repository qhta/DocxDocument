namespace DocumentModel.Math;
/// <summary>
///   Defines the ScriptValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.ScriptValues))]
public enum RunScript
{
  /// <summary>
  ///   Roman.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ScriptValues.Roman))]
  Roman,
  /// <summary>
  ///   Script.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ScriptValues.Script))]
  Script,
  /// <summary>
  ///   Fraktur.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ScriptValues.Fraktur))]
  Fraktur,
  /// <summary>
  ///   double-struck.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ScriptValues.DoubleStruck))]
  DoubleStruck,
  /// <summary>
  ///   Sans-Serif.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ScriptValues.SansSerif))]
  SansSerif,
  /// <summary>
  ///   Monospace.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ScriptValues.Monospace))]
  Monospace
}