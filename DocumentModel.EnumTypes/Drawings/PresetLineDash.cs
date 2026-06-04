namespace DocumentModel.Drawings;
/// <summary>
///   Preset ILine Dash Value
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues))]
public enum PresetLineDash
{
  /// <summary>
  ///   Solid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid))]
  Solid,
  /// <summary>
  ///   Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Dot))]
  Dot,
  /// <summary>
  ///   Dash.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Dash))]
  Dash,
  /// <summary>
  ///   Large Dash.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.LargeDash))]
  LargeDash,
  /// <summary>
  ///   Dash Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.DashDot))]
  DashDot,
  /// <summary>
  ///   Large Dash Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.LargeDashDot))]
  LargeDashDot,
  /// <summary>
  ///   Large Dash Dot Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.LargeDashDotDot))]
  LargeDashDotDot,
  /// <summary>
  ///   System Dash.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.SystemDash))]
  SystemDash,
  /// <summary>
  ///   System Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.SystemDot))]
  SystemDot,
  /// <summary>
  ///   System Dash Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.SystemDashDot))]
  SystemDashDot,
  /// <summary>
  ///   System Dash Dot Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetLineDashValues.SystemDashDotDot))]
  SystemDashDotDot
}
