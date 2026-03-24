namespace DocumentModel.Vml;
/// <summary>
///   Shadow Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.ShadowValues))]
public enum ShadowType
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Single Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ShadowValues.Single))]
  Single = 1,

  /// <summary>
  ///   Double Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ShadowValues.Double))]
  Double,
  /// <summary>
  ///   Embossed Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ShadowValues.Emboss))]
  Emboss,
  /// <summary>
  ///   Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ShadowValues.Perspective))]
  Perspective,
  /// <summary>
  ///   shapeRelative.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ShadowValues.ShapeRelative))]
  ShapeRelative,
  /// <summary>
  ///   drawingRelative.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ShadowValues.DrawingRelative))]
  DrawingRelative
}