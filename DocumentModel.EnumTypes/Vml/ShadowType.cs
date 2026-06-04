namespace DocumentModel.Vml;
/// <summary>
///   Shadow Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.ShadowValues))]
public enum ShadowType
{
  /// <summary>
  ///   Single Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ShadowValues.Single))]
  Single = 1,

  /// <summary>
  ///   Double Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ShadowValues.Double))]
  Double,
  /// <summary>
  ///   Embossed Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ShadowValues.Emboss))]
  Emboss,
  /// <summary>
  ///   Perspective Shadow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ShadowValues.Perspective))]
  Perspective,
  /// <summary>
  ///   shapeRelative.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ShadowValues.ShapeRelative))]
  ShapeRelative,
  /// <summary>
  ///   drawingRelative.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ShadowValues.DrawingRelative))]
  DrawingRelative
}