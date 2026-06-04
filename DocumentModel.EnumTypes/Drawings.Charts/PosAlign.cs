namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PosAlign enumeration.
/// Used in types such as IChartTitle, ILegend, PosAlign.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PosAlign
{
  /// <summary>
  ///   min.
  /// </summary>
  [OpenXmlEnumValue("Min")]
  Min,
  /// <summary>
  ///   ctr.
  /// </summary>
  [OpenXmlEnumValue("Ctr")]
  Ctr,
  /// <summary>
  ///   max.
  /// </summary>
  [OpenXmlEnumValue("Max")]
  Max
}

