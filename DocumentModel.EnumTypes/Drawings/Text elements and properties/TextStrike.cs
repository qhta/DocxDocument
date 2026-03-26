namespace DocumentModel.Drawings;
/// <summary>
///   Text Strike Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextStrikeValues))]
public enum TextStrike
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Text Strike Enum ( No Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextStrikeValues.NoStrike))]
  NoStrike = 1,

  /// <summary>
  ///   Text Strike Enum ( Single Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextStrikeValues.SingleStrike))]
  SingleStrike,
  /// <summary>
  ///   Text Strike Enum ( Double Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextStrikeValues.DoubleStrike))]
  DoubleStrike
}