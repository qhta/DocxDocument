namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Preset ILine Dash Value
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
  ///   ISystem Dash.
  /// </summary>
  SystemDash,

  /// <summary>
  ///   ISystem Dot.
  /// </summary>
  SystemDot,

  /// <summary>
  ///   ISystem Dash Dot.
  /// </summary>
  SystemDashDot,

  /// <summary>
  ///   ISystem Dash Dot Dot.
  /// </summary>
  SystemDashDotDot
}
