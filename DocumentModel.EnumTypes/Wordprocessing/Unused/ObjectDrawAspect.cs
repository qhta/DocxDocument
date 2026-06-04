namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ObjectDrawAspect enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect))]
public enum ObjectDrawAspect
{
  /// <summary>
  ///   content.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect.content))]
  Content,
  /// <summary>
  ///   icon.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect.icon))]
  Icon
}