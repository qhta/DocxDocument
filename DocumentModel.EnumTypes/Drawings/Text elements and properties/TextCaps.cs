namespace DocumentModel.Drawings;
/// <summary>
///   Text Cap Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextCapsValues))]
public enum TextCaps
{
  /// <summary>
  ///   Text Caps Enum ( None ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextCapsValues.None))]
  None = 1,
  /// <summary>
  ///   Text Caps Enum ( Small ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextCapsValues.Small))]
  Small,
  /// <summary>
  ///   Text Caps Enum ( All ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextCapsValues.All))]
  All
}