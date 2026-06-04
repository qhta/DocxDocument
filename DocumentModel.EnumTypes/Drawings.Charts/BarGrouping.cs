namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarGrouping enumeration.
/// Used in types such as Bar3DChart, BarChart, Bar3DChartConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues))]
public enum BarGrouping
{
  /// <summary>
  ///   100% Stacked.
  /// </summary>
  [OpenXmlEnumValue("PercentStacked")]
  PercentStacked,
  /// <summary>
  ///   Clustered.
  /// </summary>
  [OpenXmlEnumValue("Clustered")]
  Clustered,
  /// <summary>
  ///   Standard.
  /// </summary>
  [OpenXmlEnumValue("Standard")]
  Standard,
  /// <summary>
  ///   Stacked.
  /// </summary>
  [OpenXmlEnumValue("Stacked")]
  Stacked
}

