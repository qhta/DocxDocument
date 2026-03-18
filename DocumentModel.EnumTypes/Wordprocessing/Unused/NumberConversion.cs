namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberConversion enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum NumberConversion
{
  /// <summary>Convert to Arabic numerals</summary>
  [OpenXmlEnumValue("Arabic")]
  Arabic = 0,
  /// <summary>Convert to lowercase letters</summary>
  [OpenXmlEnumValue("LowerLetter")]
  LowerLetter = 1,
  /// <summary>Convert to uppercase letters</summary>
  [OpenXmlEnumValue("UpperLetter")]
  UpperLetter = 2,
  /// <summary>Convert to lowercase Roman numerals</summary>
  [OpenXmlEnumValue("LowerRoman")]
  LowerRoman = 3,
  /// <summary>Convert to uppercase Roman numerals</summary>
  [OpenXmlEnumValue("UpperRoman")]
  UpperRoman = 4
}
