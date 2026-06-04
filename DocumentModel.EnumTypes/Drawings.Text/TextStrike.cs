namespace DocumentModel.Drawings;
/// <summary>
///   Text Strike Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextStrikeValues))]
public enum TextStrike
{
  /// <summary>
  ///   Text Strike Enum ( No Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextStrikeValues.NoStrike))]
  None = 1,

  /// <summary>
  ///   Text Strike Enum ( Single Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextStrikeValues.SingleStrike))]
  Single,
  /// <summary>
  ///   Text Strike Enum ( Double Strike ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextStrikeValues.DoubleStrike))]
  Double
}