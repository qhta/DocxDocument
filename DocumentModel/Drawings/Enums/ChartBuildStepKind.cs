namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IChart Animation Build Step
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ChartBuildStepKind
{
  /// <summary>
  ///   ICategory.
  /// </summary>
  ICategory,

  /// <summary>
  ///   ICategory IPoints.
  /// </summary>
  CategoryPoints,

  /// <summary>
  ///   ISeries.
  /// </summary>
  ISeries,

  /// <summary>
  ///   ISeries IPoints.
  /// </summary>
  SeriesPoints,

  /// <summary>
  ///   All IPoints.
  /// </summary>
  AllPoints,

  /// <summary>
  ///   Grid and ILegend.
  /// </summary>
  GridLegend
}
