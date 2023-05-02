namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PresetLineDashValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetLineDashKind
{
  /// <summary>
  ///   solid.
  /// </summary>
  Solid,

  /// <summary>
  ///   dot.
  /// </summary>
  Dot,

  /// <summary>
  ///   sysDot.
  /// </summary>
  SysDot,

  /// <summary>
  ///   dash.
  /// </summary>
  Dash,

  /// <summary>
  ///   sysDash.
  /// </summary>
  SysDash,

  /// <summary>
  ///   lgDash.
  /// </summary>
  LongDash,

  /// <summary>
  ///   dashDot.
  /// </summary>
  DashDot,

  /// <summary>
  ///   sysDashDot.
  /// </summary>
  SystemDashDot,

  /// <summary>
  ///   lgDashDot.
  /// </summary>
  LongDashDot,

  /// <summary>
  ///   lgDashDotDot.
  /// </summary>
  LongDashDotDot,

  /// <summary>
  ///   sysDashDotDot.
  /// </summary>
  SystemDashDotDot
}