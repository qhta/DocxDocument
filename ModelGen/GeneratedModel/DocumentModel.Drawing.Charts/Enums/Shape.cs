namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Shape
/// </summary>
public enum Shape
{
  /// <summary>
  /// Cone.
  /// </summary>
  [XmlEnum("cone")]
  Cone,
  
  /// <summary>
  /// Cone to Max.
  /// </summary>
  [XmlEnum("coneToMax")]
  ConeToMax,
  
  /// <summary>
  /// Box.
  /// </summary>
  [XmlEnum("box")]
  Box,
  
  /// <summary>
  /// Cylinder.
  /// </summary>
  [XmlEnum("cylinder")]
  Cylinder,
  
  /// <summary>
  /// Pyramid.
  /// </summary>
  [XmlEnum("pyramid")]
  Pyramid,
  
  /// <summary>
  /// Pyramid to Maximum.
  /// </summary>
  [XmlEnum("pyramidToMax")]
  PyramidToMaximum,
  
}
