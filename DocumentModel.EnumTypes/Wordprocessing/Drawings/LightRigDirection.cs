namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the direction options for a light rig in WordprocessingML drawings.
/// This enumeration provides values for various lighting directions, supporting advanced 3D rendering and shading effects for graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LightRigDirectionValues))]
public enum LightRigDirection
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  /// Top left direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.TopLeft))]
  TopLeft = 1,

  /// <summary>
  /// Top direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Top))]
  Top,
  /// <summary>
  /// Top right direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.TopRight))]
  TopRight,
  /// <summary>
  /// Left direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Left))]
  Left,
  /// <summary>
  /// Right direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Right))]
  Right,
  /// <summary>
  /// Bottom left direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  /// Bottom direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Bottom))]
  Bottom,
  /// <summary>
  /// Bottom right direction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.BottomRight))]
  BottomRight
}