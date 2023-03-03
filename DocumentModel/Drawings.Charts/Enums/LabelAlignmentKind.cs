namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Label Alignment
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LabelAlignmentKind
{
  /// <summary>
  ///   Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Left.
  /// </summary>
  Left,

  /// <summary>
  ///   Right.
  /// </summary>
  Right
}