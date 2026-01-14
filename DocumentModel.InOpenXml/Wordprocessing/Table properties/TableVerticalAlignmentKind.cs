namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableVerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableVerticalAlignmentKind
{
  /// <summary>
  ///   top.
  /// </summary>
  Top,
  /// <summary>
  ///   center.
  /// </summary>
  Center,
  /// <summary>
  ///   bottom.
  /// </summary>
  Bottom
}