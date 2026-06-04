namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Text Wrapping Side
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues))]
public enum WrapSideKind
{
  /// <summary>
  ///   Both sides.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues.Both))]
  Both,
  /// <summary>
  ///   Left side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues.Left))]
  Left,
  /// <summary>
  ///   Right side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues.Right))]
  Right,
  /// <summary>
  ///   Largest side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues.Largest))]
  Largest
}