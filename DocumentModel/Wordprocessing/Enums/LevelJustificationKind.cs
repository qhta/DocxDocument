namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
