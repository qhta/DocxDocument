namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TimeUnit enumeration.
/// Used in types such as DateAxis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.TimeUnitValues))]
public enum TimeUnit
{
  /// <summary>
  ///   Days.
  /// </summary>
  [OpenXmlEnumValue("Days")]
  Days,
  /// <summary>
  ///   Months.
  /// </summary>
  [OpenXmlEnumValue("Months")]
  Months,
  /// <summary>
  ///   Years.
  /// </summary>
  [OpenXmlEnumValue("Years")]
  Years
}

