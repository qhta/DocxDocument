namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalAlignmentKind
{
  /// <summary>
  ///   Left Aligned Horizontally.
  /// </summary>
  Left,

  /// <summary>
  ///   Centered Horizontally.
  /// </summary>
  Center,

  /// <summary>
  ///   Right Aligned Horizontally.
  /// </summary>
  Right,

  /// <summary>
  ///   Inside.
  /// </summary>
  Inside,

  /// <summary>
  ///   Outside.
  /// </summary>
  Outside
}