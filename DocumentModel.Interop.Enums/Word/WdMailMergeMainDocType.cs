namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mail merge document.
/// </summary>
public enum WdMailMergeMainDocType
{
  /// <summary>
  /// Form letter.
  /// </summary>
  FormLetters = unchecked((int)0),
  /// <summary>
  /// Mailing label.
  /// </summary>
  MailingLabels = unchecked((int)1),
  /// <summary>
  /// Envelope.
  /// </summary>
  Envelopes = unchecked((int)2),
  /// <summary>
  /// Directory.
  /// </summary>
  Directory = unchecked((int)3),
  /// <summary>
  /// Catalog.
  /// </summary>
  Catalog = unchecked((int)3),
  /// <summary>
  /// E-mail message.
  /// </summary>
  EMail = unchecked((int)4),
  /// <summary>
  /// Fax.
  /// </summary>
  Fax = unchecked((int)5),
  /// <summary>
  /// Specifies a type of mail merge document.
  /// </summary>
  NotAMergeDocument = unchecked((int)-1)
}
