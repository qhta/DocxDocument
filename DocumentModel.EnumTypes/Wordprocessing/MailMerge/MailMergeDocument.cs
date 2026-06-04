namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeDocumentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues))]
public enum MailMergeDocument
{
  /// <summary>
  ///   Catalog Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues.Catalog))]
  Catalog,
  /// <summary>
  ///   Envelope Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues.Envelope))]
  Envelope,
  /// <summary>
  ///   Mailing Label Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues.MailingLabel))]
  MailingLabel,
  /// <summary>
  ///   Form Letter Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues.FormLetter))]
  FormLetter,
  /// <summary>
  ///   E-Mail Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues.Email))]
  Email,
  /// <summary>
  ///   Fax Source Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues.Fax))]
  Fax
}