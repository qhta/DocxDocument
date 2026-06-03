namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeDocumentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MailMergeDocumentValues))]
public enum MailMergeDocument
{
  /// <summary>
  ///   Catalog Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDocumentValues.Catalog))]
  Catalog,
  /// <summary>
  ///   Envelope Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDocumentValues.Envelope))]
  Envelope,
  /// <summary>
  ///   Mailing Label Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDocumentValues.MailingLabel))]
  MailingLabel,
  /// <summary>
  ///   Form Letter Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDocumentValues.FormLetter))]
  FormLetter,
  /// <summary>
  ///   E-Mail Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDocumentValues.Email))]
  Email,
  /// <summary>
  ///   Fax Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDocumentValues.Fax))]
  Fax
}