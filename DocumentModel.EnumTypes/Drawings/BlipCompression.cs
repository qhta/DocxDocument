namespace DocumentModel.Drawings;
/// <summary>
///   Blip Compression Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.BlipCompressionValues))]
public enum BlipCompression
{
  /// <summary>
  ///   IEmail Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlipCompressionValues.Email))]
  IEmail,
  /// <summary>
  ///   Screen Viewing Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlipCompressionValues.Screen))]
  Screen,
  /// <summary>
  ///   Printing Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlipCompressionValues.Print))]
  Print,
  /// <summary>
  ///   High Quality Printing Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlipCompressionValues.HighQualityPrint))]
  HighQualityPrint,
  /// <summary>
  ///   No Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlipCompressionValues.None))]
  None
}
