namespace DocumentModel.Vml;
/// <summary>
///   Image Scaling Behavior
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.ImageAspectValues))]
public enum ImageAspectType
{
  /// <summary>
  ///   Ignore Aspect Ratio.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ImageAspectValues.Ignore))]
  Ignore,
  /// <summary>
  ///   At Most.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ImageAspectValues.AtMost))]
  AtMost,
  /// <summary>
  ///   At Least.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ImageAspectValues.AtLeast))]
  AtLeast
}