namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the IShape enumeration.
/// Used in types such as AdjustHandleList, AdjustHandlePolar, AdjustValueList.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeValues))]
public enum Shape
{
  /// <summary>
  ///   Cone.
  /// </summary>
  [OpenXmlEnumValue("Cone")]
  Cone,
  /// <summary>
  ///   Cone to Max.
  /// </summary>
  [OpenXmlEnumValue("ConeToMax")]
  ConeToMax,
  /// <summary>
  ///   Box.
  /// </summary>
  [OpenXmlEnumValue("Box")]
  Box,
  /// <summary>
  ///   Cylinder.
  /// </summary>
  [OpenXmlEnumValue("Cylinder")]
  Cylinder,
  /// <summary>
  ///   Pyramid.
  /// </summary>
  [OpenXmlEnumValue("Pyramid")]
  Pyramid,
  /// <summary>
  ///   Pyramid to Maximum.
  /// </summary>
  [OpenXmlEnumValue("PyramidToMaximum")]
  PyramidToMaximum
}

