namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineSpacingRuleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineSpacingRuleKind
{
  /// <summary>
  ///   Automatically Determined ILine Height.
  /// </summary>
  Auto,

  /// <summary>
  ///   Exact ILine Height.
  /// </summary>
  Exact,

  /// <summary>
  ///   Minimum ILine Height.
  /// </summary>
  AtLeast
}
