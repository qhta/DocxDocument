namespace DocumentModel.Drawings;
/// <summary>
///   Text Strike Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextStrikeValues))]
public enum TextStrike
{
  /// <summary>
  ///   Text Strike Enum ( No Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextStrikeValues.NoStrike))]
  None = 1,

  /// <summary>
  ///   Text Strike Enum ( Single Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextStrikeValues.SingleStrike))]
  Single,
  /// <summary>
  ///   Text Strike Enum ( Double Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextStrikeValues.DoubleStrike))]
  Double
}