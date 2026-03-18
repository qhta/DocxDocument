namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the PosAlign enumeration.
/// Used in types such as ChartTitle, Legend, PosAlign.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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
