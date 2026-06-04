namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HangulHanjaConversion enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HangulHanjaConversion
{
  /// <summary>Hangul to Hanja</summary>
  [OpenXmlEnumValue("HangulToHanja")]
  HangulToHanja,
  /// <summary>Hanja to Hangul</summary>
  [OpenXmlEnumValue("HanjaToHangul")]
  HanjaToHangul
}
