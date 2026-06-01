namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalAlignmentKind
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  Left,

  /// <summary>
  ///   Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Right.
  /// </summary>
  Right
}
