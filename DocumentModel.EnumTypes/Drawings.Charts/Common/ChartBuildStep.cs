namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartBuildStep enumeration.
/// Used in types such as ChartToAnimate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.ChartBuildStepValues))]
public enum ChartBuildStep
{
  /// <summary>
  ///   Category.
  /// </summary>
  [OpenXmlEnumValue("Category")]
  Category,
  /// <summary>
  ///   Category Points.
  /// </summary>
  [OpenXmlEnumValue("CategoryPoints")]
  CategoryPoints,
  /// <summary>
  ///   Series.
  /// </summary>
  [OpenXmlEnumValue("Series")]
  Series,
  /// <summary>
  ///   Series Points.
  /// </summary>
  [OpenXmlEnumValue("SeriesPoints")]
  SeriesPoints,
  /// <summary>
  ///   All Points.
  /// </summary>
  [OpenXmlEnumValue("AllPoints")]
  AllPoints,
  /// <summary>
  ///   Grid and Legend.
  /// </summary>
  [OpenXmlEnumValue("GridLegend")]
  GridLegend
}
