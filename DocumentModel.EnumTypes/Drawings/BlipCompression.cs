namespace DocumentModel.Drawings;
/// <summary>
///   Blip Compression Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.BlipCompressionValues))]
public enum BlipCompression
{
  /// <summary>
  ///   IEmail Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlipCompressionValues.Email))]
  IEmail,
  /// <summary>
  ///   Screen Viewing Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlipCompressionValues.Screen))]
  Screen,
  /// <summary>
  ///   Printing Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlipCompressionValues.Print))]
  Print,
  /// <summary>
  ///   High Quality Printing Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlipCompressionValues.HighQualityPrint))]
  HighQualityPrint,
  /// <summary>
  ///   No Compression.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlipCompressionValues.None))]
  None
}
