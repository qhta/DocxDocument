namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocumentTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DocumentTypeValues))]
public enum DocumentKind
{
  /// <summary>
  ///   Default Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentTypeValues.NotSpecified))]
  NotSpecified,
  /// <summary>
  ///   Letter.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentTypeValues.Letter))]
  Letter,
  /// <summary>
  ///   E-Mail Message.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentTypeValues.Email))]
  Email
}