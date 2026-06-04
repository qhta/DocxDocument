namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
/// Defines the WrapSide enumeration.
/// Used in types such as TextWrap, WrapSide.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues))]
public enum WrapSide
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
