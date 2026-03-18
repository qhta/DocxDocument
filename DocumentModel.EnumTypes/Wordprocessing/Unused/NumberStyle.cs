namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberStyle enumeration.
/// Used in types such as CaptionLabel, ListLevel, PageNumbers.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum NumberStyle
{
  /// <summary>Arabic numbers (1, 2, 3...)</summary>
  [OpenXmlEnumValue("Arabic")]
  Arabic = 0,
  /// <summary>Uppercase Roman numerals (I, II, III...)</summary>
  [OpenXmlEnumValue("UpperRoman")]
  UpperRoman = 1,
  /// <summary>Lowercase Roman numerals (i, ii, iii...)</summary>
  [OpenXmlEnumValue("LowerRoman")]
  LowerRoman = 2,
  /// <summary>Uppercase letters (A, B, C...)</summary>
  [OpenXmlEnumValue("UpperLetter")]
  UpperLetter = 3,
  /// <summary>Lowercase letters (a, b, c...)</summary>
  [OpenXmlEnumValue("LowerLetter")]
  LowerLetter = 4,
  /// <summary>Ordinal numbers (1st, 2nd, 3rd...)</summary>
  [OpenXmlEnumValue("Ordinal")]
  Ordinal = 5,
  /// <summary>Cardinal numbers (One, Two, Three...)</summary>
  [OpenXmlEnumValue("Cardinal")]
  Cardinal = 6
}
