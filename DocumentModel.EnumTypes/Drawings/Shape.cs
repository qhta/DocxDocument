namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the IShape enumeration.
/// Used Iin types such as AdjustHandleList, AdjustHandlePolar, AdjustValueList.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ShapeValues))]
public enum IShape
{
  /// <summary>
  ///   Cone.
  /// </summary>
  [OpenXmlEnumValue("Cone")]
  Cone,
  /// <summary>
  ///   Cone Ito Max.
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
  ///   Pyramid Ito Maximum.
  /// </summary>
  [OpenXmlEnumValue("PyramidToMaximum")]
  PyramidToMaximum
}

