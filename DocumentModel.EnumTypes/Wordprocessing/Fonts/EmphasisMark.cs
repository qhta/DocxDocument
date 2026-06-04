namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the EmphasisMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues))]
public enum EmphasisMark
{
  /// <summary>
  ///   No Emphasis Mark.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues.None))]
  None,
  /// <summary>
  ///   Dot Emphasis Mark Above Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues.Dot))]
  Dot,
  /// <summary>
  ///   Comma Emphasis Mark Above Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues.Comma))]
  Comma,
  /// <summary>
  ///   Circle Emphasis Mark Above Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues.Circle))]
  Circle,
  /// <summary>
  ///   Dot Emphasis Mark Below Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues.UnderDot))]
  UnderDot
}