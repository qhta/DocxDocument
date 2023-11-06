namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HeightRuleValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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