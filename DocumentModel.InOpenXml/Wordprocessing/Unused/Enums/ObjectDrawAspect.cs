namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ObjectDrawAspect enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ObjectDrawAspect))]
public enum ObjectDrawAspect
{
  /// <summary>
  ///   content.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ObjectDrawAspect.content))]
  Content,
  /// <summary>
  ///   icon.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ObjectDrawAspect.icon))]
  Icon
}