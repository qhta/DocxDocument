namespace DocumentModel.Vml;
/// <summary>
///   Image Scaling Behavior
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.ImageAspectValues))]
public enum ImageAspectKind
{
  /// <summary>
  ///   Ignore Aspect Ratio.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ImageAspectValues.Ignore))]
  Ignore,
  /// <summary>
  ///   At Most.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ImageAspectValues.AtMost))]
  AtMost,
  /// <summary>
  ///   At Least.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ImageAspectValues.AtLeast))]
  AtLeast
}