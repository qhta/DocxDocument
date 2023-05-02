namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Preset Line Dash Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetLineDashKind
{
  /// <summary>
  ///   Solid.
  /// </summary>
  Solid,

  /// <summary>
  ///   Dot.
  /// </summary>
  Dot,

  /// <summary>
  ///   Dash.
  /// </summary>
  Dash,

  /// <summary>
  ///   Large Dash.
  /// </summary>
  LargeDash,

  /// <summary>
  ///   Dash Dot.
  /// </summary>
  DashDot,

  /// <summary>
  ///   Large Dash Dot.
  /// </summary>
  LargeDashDot,

  /// <summary>
  ///   Large Dash Dot Dot.
  /// </summary>
  LargeDashDotDot,

  /// <summary>
  ///   System Dash.
  /// </summary>
  SystemDash,

  /// <summary>
  ///   System Dot.
  /// </summary>
  SystemDot,

  /// <summary>
  ///   System Dash Dot.
  /// </summary>
  SystemDashDot,

  /// <summary>
  ///   System Dash Dot Dot.
  /// </summary>
  SystemDashDotDot
}