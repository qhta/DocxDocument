namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BuiltInUnit enumeration.
/// Used Iin types such as DisplayUnits, DisplayUnitsConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.BuiltInUnitValues))]
public enum BuiltInUnit
{
  /// <summary>
  ///   Hundreds.
  /// </summary>
  [OpenXmlEnumValue("Hundreds")]
  Hundreds,
  /// <summary>
  ///   Thousands.
  /// </summary>
  [OpenXmlEnumValue("Thousands")]
  Thousands,
  /// <summary>
  ///   Ten Thousands.
  /// </summary>
  [OpenXmlEnumValue("TenThousands")]
  TenThousands,
  /// <summary>
  ///   Hundred Thousands.
  /// </summary>
  [OpenXmlEnumValue("HundredThousands")]
  HundredThousands,
  /// <summary>
  ///   Millions.
  /// </summary>
  [OpenXmlEnumValue("Millions")]
  Millions,
  /// <summary>
  ///   Ten Millions.
  /// </summary>
  [OpenXmlEnumValue("TenMillions")]
  TenMillions,
  /// <summary>
  ///   Hundred Millions.
  /// </summary>
  [OpenXmlEnumValue("HundredMillions")]
  HundredMillions,
  /// <summary>
  ///   Billions.
  /// </summary>
  [OpenXmlEnumValue("Billions")]
  Billions,
  /// <summary>
  ///   Trillions.
  /// </summary>
  [OpenXmlEnumValue("Trillions")]
  Trillions
}

