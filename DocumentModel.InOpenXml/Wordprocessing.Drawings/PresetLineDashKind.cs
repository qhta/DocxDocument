namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the preset line dash style options for drawing lines in WordprocessingML documents.
/// This enumeration provides values for different dash and dot patterns, supporting advanced graphical rendering and customization of line styles in document drawings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetLineDashKind
{
  /// <summary>
  /// Solid line.
  /// </summary>
  Solid,

  /// <summary>
  /// Dotted line.
  /// </summary>
  Dot,

  /// <summary>
  /// System-defined dotted line.
  /// </summary>
  SysDot,

  /// <summary>
  /// Dashed line.
  /// </summary>
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
  DashDot,

  /// <summary>
  /// System-defined dash-dot line.
  /// </summary>
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
  SystemDashDotDot
}