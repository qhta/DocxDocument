namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableRowAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableRowAlignmentKind
{
  /// <summary>
  ///   left.
  /// </summary>
  Left,

  /// <summary>
  ///   center.
  /// </summary>
  Center,

  /// <summary>
  ///   right.
  /// </summary>
  Right
}