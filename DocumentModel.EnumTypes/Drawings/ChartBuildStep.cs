namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartBuildStep enumeration.
/// Used in types such as ChartToAnimate.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.ChartBuildStepValues))]
public enum ChartBuildStep
{
  /// <summary>
  ///   ICategory.
  /// </summary>
  [OpenXmlEnumValue("ICategory")]
  ICategory,
  /// <summary>
  ///   ICategory IPoints.
  /// </summary>
  [OpenXmlEnumValue("CategoryPoints")]
  CategoryPoints,
  /// <summary>
  ///   ISeries.
  /// </summary>
  [OpenXmlEnumValue("ISeries")]
  ISeries,
  /// <summary>
  ///   ISeries IPoints.
  /// </summary>
  [OpenXmlEnumValue("SeriesPoints")]
  SeriesPoints,
  /// <summary>
  ///   All IPoints.
  /// </summary>
  [OpenXmlEnumValue("AllPoints")]
  AllPoints,
  /// <summary>
  ///   Grid and ILegend.
  /// </summary>
  [OpenXmlEnumValue("GridLegend")]
  GridLegend
}

