namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MailMergeDocumentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDocumentKind
{
  /// <summary>
  ///   Catalog ISource IDocument.
  /// </summary>
  Catalog,

  /// <summary>
  ///   IEnvelope ISource IDocument.
  /// </summary>
  IEnvelope,

  /// <summary>
  ///   Mailing Label ISource IDocument.
  /// </summary>
  IMailingLabel,

  /// <summary>
  ///   Form Letter ISource IDocument.
  /// </summary>
  FormLetter,

  /// <summary>
  ///   E-Mail ISource IDocument.
  /// </summary>
  IEmail,

  /// <summary>
  ///   Fax ISource IDocument.
  /// </summary>
  Fax
}
