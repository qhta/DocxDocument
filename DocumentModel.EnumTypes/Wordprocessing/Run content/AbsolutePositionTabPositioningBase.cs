namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the AbsolutePositionTabPositioningBaseValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.AbsolutePositionTabPositioningBaseValues))]
public enum AbsolutePositionTabPositioningBase
{
  /// <summary>
  ///   Relative To Text Margins.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabPositioningBaseValues.Margin))]
  Margin,
  /// <summary>
  ///   Relative To Indents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabPositioningBaseValues.Indent))]
  Indent
}