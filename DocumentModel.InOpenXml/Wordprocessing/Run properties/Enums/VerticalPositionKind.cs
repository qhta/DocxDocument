namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalPositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.VerticalPositionValues))]
public enum VerticalPositionKind
{
  /// <summary>
  ///   Regular Vertical Positioning.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalPositionValues.Baseline))]
  Baseline,
  /// <summary>
  ///   Superscript.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalPositionValues.Superscript))]
  Superscript,
  /// <summary>
  ///   Subscript.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalPositionValues.Subscript))]
  Subscript
}