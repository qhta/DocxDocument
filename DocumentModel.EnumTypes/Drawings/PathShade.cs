namespace DocumentModel.Drawings;
/// <summary>
///   Path Shade Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PathShadeValues))]
public enum PathShade
{
  /// <summary>
  ///   IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Shape))]
  IShape,
  /// <summary>
  ///   Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Circle))]
  Circle,
  /// <summary>
  ///   IRectangle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Rectangle))]
  IRectangle
}
