namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocumentTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues))]
public enum DocumentType
{
  /// <summary>
  ///   Default Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues.NotSpecified))]
  NotSpecified,
  /// <summary>
  ///   Letter.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues.Letter))]
  Letter,
  /// <summary>
  ///   E-Mail Message.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues.Email))]
  Email
}