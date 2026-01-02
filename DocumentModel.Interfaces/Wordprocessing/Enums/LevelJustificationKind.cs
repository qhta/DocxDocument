namespace DocumentModel.Wordprocessing;

/// <summary>
///   Horizontal Alignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LevelJustificationKind
{
  /// <summary>
  ///   Align Left.
  /// </summary>
  Left,
  /// <summary>
  ///   Align Center.
  /// </summary>
  Center,
  /// <summary>
  ///   Align Right.
  /// </summary>
  Right
}