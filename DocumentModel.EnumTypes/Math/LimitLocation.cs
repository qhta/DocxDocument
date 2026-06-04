namespace DocumentModel.Math;
/// <summary>
///   Defines the LimitLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.LimitLocationValues))]
public enum LimitLocation
{
  /// <summary>
  ///   Under-Over location.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.LimitLocationValues.UnderOver))]
  UnderOver,
  /// <summary>
  ///   Subscript-Superscript location.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.LimitLocationValues.SubscriptSuperscript))]
  SubscriptSuperscript
}