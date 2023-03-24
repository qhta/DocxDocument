namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the AbsolutePositionTabAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AbsolutePositionTabAlignmentKind
{
  /// <summary>
  ///   Left.
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