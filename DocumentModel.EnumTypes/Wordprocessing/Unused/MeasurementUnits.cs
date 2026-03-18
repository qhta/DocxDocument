namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MeasurementUnits enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum MeasurementUnits
{
  /// <summary>Inches</summary>
  [OpenXmlEnumValue("Inches")]
  Inches,
  /// <summary>Centimeters</summary>
  [OpenXmlEnumValue("Centimeters")]
  Centimeters,
  /// <summary>Millimeters</summary>
  [OpenXmlEnumValue("Millimeters")]
  Millimeters,
  /// <summary>Points</summary>
  [OpenXmlEnumValue("Points")]
  Points,
  /// <summary>Picas</summary>
  [OpenXmlEnumValue("Picas")]
  Picas
}
