namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the path shading type options for graphical elements in WordprocessingML drawings.
/// This enumeration provides values for different shading paths, supporting advanced visual effects and gradient fills for shapes and graphical content within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PathShadeValues))]
public enum PathShade
{
  /// <summary>
  /// Shape path shading.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Shape))]
  Shape,
  /// <summary>
  /// Circle path shading.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Circle))]
  Circle,
  /// <summary>
  /// Rectangle path shading.
  /// </summary>
  Rect
}