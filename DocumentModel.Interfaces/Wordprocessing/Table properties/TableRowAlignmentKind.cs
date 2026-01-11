namespace DocumentModel.Wordprocessing;

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