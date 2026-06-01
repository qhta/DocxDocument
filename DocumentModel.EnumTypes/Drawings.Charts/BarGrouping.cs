namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarGrouping enumeration.
/// Used Iin types such as Bar3DChart, BarChart, Bar3DChartConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.BarGroupingValues))]
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

