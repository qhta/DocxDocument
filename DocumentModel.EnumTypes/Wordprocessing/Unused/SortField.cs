namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SortField enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SortField
{
  /// <summary>Alphanumeric</summary>
  [OpenXmlEnumValue("Alphanumeric")]
  Alphanumeric,
  /// <summary>Numeric</summary>
  [OpenXmlEnumValue("Numeric")]
  Numeric,
  /// <summary>Date</summary>
  [OpenXmlEnumValue("Date")]
  Date,
  /// <summary>Japanese JIS</summary>
  [OpenXmlEnumValue("JIS")]
  JIS,
  /// <summary>Kana</summary>
  [OpenXmlEnumValue("Kana")]
  Kana,
  /// <summary>Stroke</summary>
  [OpenXmlEnumValue("Stroke")]
  Stroke,
  /// <summary>Syllable</summary>
  [OpenXmlEnumValue("Syllable")]
  Syllable,
  /// <summary>Korean KS</summary>
  [OpenXmlEnumValue("KoreanKS")]
  KoreanKS
}
