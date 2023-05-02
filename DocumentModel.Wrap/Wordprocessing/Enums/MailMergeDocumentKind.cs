namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MailMergeDocumentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDocumentKind
{
  /// <summary>
  ///   Catalog Source Document.
  /// </summary>
  Catalog,

  /// <summary>
  ///   Envelope Source Document.
  /// </summary>
  Envelope,

  /// <summary>
  ///   Mailing Label Source Document.
  /// </summary>
  MailingLabel,

  /// <summary>
  ///   Form Letter Source Document.
  /// </summary>
  FormLetter,

  /// <summary>
  ///   E-Mail Source Document.
  /// </summary>
  Email,

  /// <summary>
  ///   Fax Source Document.
  /// </summary>
  Fax
}