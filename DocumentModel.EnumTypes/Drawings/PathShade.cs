namespace DocumentModel.Drawings;
/// <summary>
///   Path Shade Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PathShadeValues))]
public enum PathShade
{
  /// <summary>
  ///   IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathShadeValues.Shape))]
  IShape,
  /// <summary>
  ///   Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathShadeValues.Circle))]
  Circle,
  /// <summary>
  ///   IRectangle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathShadeValues.Rectangle))]
  IRectangle
}
