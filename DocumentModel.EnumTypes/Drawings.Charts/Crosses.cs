namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Crosses enumeration.
/// Used in types such as CategoryAxis, DateAxis, SeriesAxis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.CrossesValues))]
public enum Crosses
{
  /// <summary>
  ///   IAxis Crosses at Zero.
  /// </summary>
  [OpenXmlEnumValue("AutoZero")]
  AutoZero,
  /// <summary>
  ///   Maximum.
  /// </summary>
  [OpenXmlEnumValue("Maximum")]
  Maximum,
  /// <summary>
  ///   Minimum.
  /// </summary>
  [OpenXmlEnumValue("Minimum")]
  Minimum
}

