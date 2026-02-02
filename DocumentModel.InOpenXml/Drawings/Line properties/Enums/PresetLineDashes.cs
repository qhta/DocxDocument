namespace DocumentModel.Drawings;
/// <summary>
///   Preset Line Dash Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetLineDashValues))]
public enum PresetLineDashes
{
  /// <summary>
  ///   Solid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.Solid))]
  Solid,
  /// <summary>
  ///   Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.Dot))]
  Dot,
  /// <summary>
  ///   Dash.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.Dash))]
  Dash,
  /// <summary>
  ///   Large Dash.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.LargeDash))]
  LargeDash,
  /// <summary>
  ///   Dash Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.DashDot))]
  DashDot,
  /// <summary>
  ///   Large Dash Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.LargeDashDot))]
  LargeDashDot,
  /// <summary>
  ///   Large Dash Dot Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.LargeDashDotDot))]
  LargeDashDotDot,
  /// <summary>
  ///   System Dash.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.SystemDash))]
  SystemDash,
  /// <summary>
  ///   System Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.SystemDot))]
  SystemDot,
  /// <summary>
  ///   System Dash Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.SystemDashDot))]
  SystemDashDot,
  /// <summary>
  ///   System Dash Dot Dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.SystemDashDotDot))]
  SystemDashDotDot
}