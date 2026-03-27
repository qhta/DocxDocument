namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies text direction options for content in WordprocessingML documents.
/// This enumeration provides values for left-to-right and right-to-left text flows, supporting bidirectional text, internationalization, and advanced layout scenarios for languages with different writing directions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DirectionValues))]
public enum Direction
{
  /// <summary>
  /// Left-to-right text direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DirectionValues.Ltr))]
  Ltr = 1,

  /// <summary>
  /// Right-to-left text direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DirectionValues.Rtl))]
  Rtl
}