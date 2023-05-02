namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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