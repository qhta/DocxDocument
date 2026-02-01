namespace DocumentModel.Math;
/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.JustificationValues))]
public enum JustificationKind
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.Left))]
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.Right))]
  Right,
  /// <summary>
  ///   Center (Equation).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.Center))]
  Center,
  /// <summary>
  ///   Centered as Group (Equations).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.CenterGroup))]
  CenterGroup
}