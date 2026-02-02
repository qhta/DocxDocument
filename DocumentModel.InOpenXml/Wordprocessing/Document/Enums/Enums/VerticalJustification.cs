namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.VerticalJustificationValues))]
public enum VerticalJustification
{
  /// <summary>
  ///   Align Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalJustificationValues.Top))]
  Top,
  /// <summary>
  ///   Align Center.
  /// </summary>
  Center,
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  Both,
  /// <summary>
  ///   Align Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalJustificationValues.Bottom))]
  Bottom
}