namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AxisUnit enumeration.
/// Used Iin types such as AxisUnits, AxisUnit, AxisUnitsConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AxisUnit
{
  /// <summary>
  ///   hundreds.
  /// </summary>
  [OpenXmlEnumValue("Hundreds")]
  Hundreds,
  /// <summary>
  ///   thousands.
  /// </summary>
  [OpenXmlEnumValue("Thousands")]
  Thousands,
  /// <summary>
  ///   tenThousands.
  /// </summary>
  [OpenXmlEnumValue("TenThousands")]
  TenThousands,
  /// <summary>
  ///   hundredThousands.
  /// </summary>
  [OpenXmlEnumValue("HundredThousands")]
  HundredThousands,
  /// <summary>
  ///   millions.
  /// </summary>
  [OpenXmlEnumValue("Millions")]
  Millions,
  /// <summary>
  ///   tenMillions.
  /// </summary>
  [OpenXmlEnumValue("TenMillions")]
  TenMillions,
  /// <summary>
  ///   hundredMillions.
  /// </summary>
  [OpenXmlEnumValue("HundredMillions")]
  HundredMillions,
  /// <summary>
  ///   billions.
  /// </summary>
  [OpenXmlEnumValue("Billions")]
  Billions,
  /// <summary>
  ///   trillions.
  /// </summary>
  [OpenXmlEnumValue("Trillions")]
  Trillions,
  /// <summary>
  ///   percentage.
  /// </summary>
  [OpenXmlEnumValue("Percentage")]
  Percentage
}

