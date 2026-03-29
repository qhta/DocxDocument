namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Case enumeration.
/// Used in types such as AddOpenXmlElementAttribute, GenerateShouldSerializeFunctions, Variant.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum Case
{
  /// <summary>Uppercase</summary>
  [OpenXmlEnumValue("Upper")]
  Upper,
  /// <summary>Lowercase</summary>
  [OpenXmlEnumValue("Lower")]
  Lower,
  /// <summary>Title case</summary>
  [OpenXmlEnumValue("Title")]
  Title,
  /// <summary>Toggle case</summary>
  [OpenXmlEnumValue("Toggle")]
  Toggle
}
