namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Grouping
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GroupingKind
{
  /// <summary>
  ///   100% Stacked.
  /// </summary>
  PercentStacked,
  /// <summary>
  ///   Standard.
  /// </summary>
  Standard,
  /// <summary>
  ///   Stacked.
  /// </summary>
  Stacked
}