namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Cross Between
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CrossBetweenKind
{
  /// <summary>
  ///   Between.
  /// </summary>
  Between,

  /// <summary>
  ///   Midpoint of Category.
  /// </summary>
  MidpointCategory
}