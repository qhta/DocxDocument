namespace DocumentModel.Drawings;
/// <summary>
///   Light Rig Direction
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues))]
public enum LightRigDirection
{
  /// <summary>
  ///   Top Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.TopLeft))]
  TopLeft = 1,

  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.Top))]
  Top,
  /// <summary>
  ///   Top Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.TopRight))]
  TopRight,
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.Left))]
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.Right))]
  Right,
  /// <summary>
  ///   Bottom Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Bottom Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.BottomRight))]
  BottomRight
}