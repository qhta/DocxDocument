namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LineSpacingRuleValues enumeration.
/// </summary>
public enum LineSpacingRuleKind
{
  /// <summary>
  ///   Automatically Determined Line Height.
  /// </summary>
  Auto,

  /// <summary>
  ///   Exact Line Height.
  /// </summary>
  Exact,

  /// <summary>
  ///   Minimum Line Height.
  /// </summary>
  AtLeast
}