namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Split Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SplitKind
{
  /// <summary>
  ///   Custom Split.
  /// </summary>
  Custom,

  /// <summary>
  ///   Split by Percentage.
  /// </summary>
  Percent,

  /// <summary>
  ///   Split by Position.
  /// </summary>
  Position,

  /// <summary>
  ///   Split by Value.
  /// </summary>
  Value
}