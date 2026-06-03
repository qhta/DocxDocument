namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Comparison enumeration.
/// Used in types such as AddOpenXmlElementAttribute, ArrayVariant, Base64Binary.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum Comparison
{
  /// <summary>IRange is before the other range</summary>
  [OpenXmlEnumValue("Before")]
  Before,
  /// <summary>IRange is after the other range</summary>
  [OpenXmlEnumValue("After")]
  After,
  /// <summary>IRange equals the other range</summary>
  [OpenXmlEnumValue("Equal")]
  Equal,
  /// <summary>IRange contains the other range</summary>
  [OpenXmlEnumValue("Contains")]
  Contains,
  /// <summary>IRange is contained by the other range</summary>
  [OpenXmlEnumValue("ContainedBy")]
  ContainedBy,
  /// <summary>IRange overlaps the other range</summary>
  [OpenXmlEnumValue("Overlaps")]
  Overlaps
}

