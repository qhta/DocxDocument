namespace DocumentModel.Drawings.Charts;

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