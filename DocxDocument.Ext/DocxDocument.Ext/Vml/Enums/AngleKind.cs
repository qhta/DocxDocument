namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Callout Angles
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum AngleKind
{
  /// <summary>
  ///   Any Angle.
  /// </summary>
  Any,

  /// <summary>
  ///   30 degrees.
  /// </summary>
  Degree30,

  /// <summary>
  ///   45 degrees.
  /// </summary>
  Degree45,

  /// <summary>
  ///   60 degrees.
  /// </summary>
  Degree60,

  /// <summary>
  ///   90 degrees.
  /// </summary>
  Degree90,

  /// <summary>
  ///   Automatic Angle.
  /// </summary>
  Auto
}