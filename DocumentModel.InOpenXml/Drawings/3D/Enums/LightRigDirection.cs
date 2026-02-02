namespace DocumentModel.Drawings;
/// <summary>
///   Light Rig Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LightRigDirectionValues))]
public enum LightRigDirection
{
  /// <summary>
  ///   Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.TopLeft))]
  TopLeft,
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Top))]
  Top,
  /// <summary>
  ///   Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.TopRight))]
  TopRight,
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Left))]
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Right))]
  Right,
  /// <summary>
  ///   Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LightRigDirectionValues.BottomRight))]
  BottomRight
}