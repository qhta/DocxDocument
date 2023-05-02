namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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