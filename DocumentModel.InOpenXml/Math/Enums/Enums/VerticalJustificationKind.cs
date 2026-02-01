namespace DocumentModel.Math;
/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.VerticalJustificationValues))]
public enum VerticalJustificationKind
{
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalJustificationValues.Top))]
  Top,
  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalJustificationValues.Bottom))]
  Bottom
}