namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum JustificationKind
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  Left,

  /// <summary>
  ///   Right.
  /// </summary>
  Right,

  /// <summary>
  ///   Center (Equation).
  /// </summary>
  Center,

  /// <summary>
  ///   Centered as Group (Equations).
  /// </summary>
  CenterGroup
}