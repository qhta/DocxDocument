namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Text Wrapping Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues))]
public enum WrapType
{
  /// <summary>
  ///   Top and bottom wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues.TopAndBottom))]
  TopAndBottom,
  /// <summary>
  ///   Square wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues.Square))]
  Square,
  /// <summary>
  ///   No wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues.None))]
  None,
  /// <summary>
  ///   Tight wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues.Tight))]
  Tight,
  /// <summary>
  ///   Through wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues.Through))]
  Through
}