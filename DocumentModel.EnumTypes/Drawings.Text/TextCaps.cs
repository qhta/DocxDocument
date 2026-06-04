namespace DocumentModel.Drawings;
/// <summary>
///   Text Cap Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextCapsValues))]
public enum TextCaps
{
  /// <summary>
  ///   Text Caps Enum ( None ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextCapsValues.None))]
  None = 1,
  /// <summary>
  ///   Text Caps Enum ( Small ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextCapsValues.Small))]
  Small,
  /// <summary>
  ///   Text Caps Enum ( All ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextCapsValues.All))]
  All
}