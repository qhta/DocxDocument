namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mail merge document.
/// </summary>
public enum WdMailMergeMainDocType
{
  /// <summary>
  /// Form letter.
  /// </summary>
  wdFormLetters = unchecked((int)0),
  /// <summary>
  /// Mailing label.
  /// </summary>
  wdMailingLabels = unchecked((int)1),
  /// <summary>
  /// Envelope.
  /// </summary>
  wdEnvelopes = unchecked((int)2),
  /// <summary>
  /// Directory.
  /// </summary>
  wdDirectory = unchecked((int)3),
  /// <summary>
  /// Catalog.
  /// </summary>
  wdCatalog = unchecked((int)3),
  /// <summary>
  /// E-mail message.
  /// </summary>
  wdEMail = unchecked((int)4),
  /// <summary>
  /// Fax.
  /// </summary>
  wdFax = unchecked((int)5),
  /// <summary>
  /// Specifies a type of mail merge document.
  /// </summary>
  wdNotAMergeDocument = unchecked((int)-1)
}
