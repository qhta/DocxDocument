namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the preset line dash style options for drawing lines in WordprocessingML documents.
/// This enumeration provides values for different dash and dot patterns, supporting advanced graphical rendering and customization of line styles in document drawings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetLineDashValues))]
public enum PresetLineDash
{
  /// <summary>
  /// Solid line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.Solid))]
  Solid,
  /// <summary>
  /// Dotted line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.Dot))]
  Dot,
  /// <summary>
  /// System-defined dotted line.
  /// </summary>
  SysDot,
  /// <summary>
  /// Dashed line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.Dash))]
  Dash,
  /// <summary>
  /// System-defined dashed line.
  /// </summary>
  SysDash,
  /// <summary>
  /// Long dashed line.
  /// </summary>
  LongDash,
  /// <summary>
  /// Dash-dot line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.DashDot))]
  DashDot,
  /// <summary>
  /// System-defined dash-dot line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.SystemDashDot))]
  SystemDashDot,
  /// <summary>
  /// Long dash-dot line.
  /// </summary>
  LongDashDot,
  /// <summary>
  /// Long dash-dot-dot line.
  /// </summary>
  LongDashDotDot,
  /// <summary>
  /// System-defined dash-dot-dot line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetLineDashValues.SystemDashDotDot))]
  SystemDashDotDot
}