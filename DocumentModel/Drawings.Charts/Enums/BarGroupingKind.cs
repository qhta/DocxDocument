namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Bar Grouping
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BarGroupingKind
{
  /// <summary>
  ///   100% Stacked.
  /// </summary>
  PercentStacked,

  /// <summary>
  ///   Clustered.
  /// </summary>
  Clustered,

  /// <summary>
  ///   Standard.
  /// </summary>
  Standard,

  /// <summary>
  ///   Stacked.
  /// </summary>
  Stacked
}