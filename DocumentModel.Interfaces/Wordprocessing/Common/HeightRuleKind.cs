namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the HeightRuleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HeightRuleKind
{
  /// <summary>
  ///   Determine Height Based On Contents.
  /// </summary>
  Auto,
  /// <summary>
  ///   Exact Height.
  /// </summary>
  Exact,
  /// <summary>
  ///   Minimum Height.
  /// </summary>
  AtLeast
}