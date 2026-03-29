namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Comparison enumeration.
/// Used in types such as AddOpenXmlElementAttribute, ArrayVariant, Base64Binary.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum Comparison
{
  /// <summary>Range is before the other range</summary>
  [OpenXmlEnumValue("Before")]
  Before,
  /// <summary>Range is after the other range</summary>
  [OpenXmlEnumValue("After")]
  After,
  /// <summary>Range equals the other range</summary>
  [OpenXmlEnumValue("Equal")]
  Equal,
  /// <summary>Range contains the other range</summary>
  [OpenXmlEnumValue("Contains")]
  Contains,
  /// <summary>Range is contained by the other range</summary>
  [OpenXmlEnumValue("ContainedBy")]
  ContainedBy,
  /// <summary>Range overlaps the other range</summary>
  [OpenXmlEnumValue("Overlaps")]
  Overlaps
}
