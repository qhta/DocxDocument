namespace DocumentModel.Drawings;
/// <summary>
///   Path Shade Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PathShadeValues))]
public enum PathShadeKind
{
  /// <summary>
  ///   Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Shape))]
  Shape,
  /// <summary>
  ///   Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Circle))]
  Circle,
  /// <summary>
  ///   Rectangle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathShadeValues.Rectangle))]
  Rectangle
}