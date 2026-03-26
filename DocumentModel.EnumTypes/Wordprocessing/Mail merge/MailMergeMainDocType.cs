namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a type of mail merge document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergemaindoctype?view=office-pia` for Office interop details.
/// </remarks>
public enum MailMergeMainDocType
{
  /// <summary>
  /// Form letter.
  /// </summary>
  FormLetters = 0,
  /// <summary>
  /// Mailing label.
  /// </summary>
  MailingLabels = 1,
  /// <summary>
  /// Envelope.
  /// </summary>
  Envelopes = 2,
  /// <summary>
  /// Directory.
  /// </summary>
  Directory = 3,
  /// <summary>
  /// Catalog.
  /// </summary>
  Catalog = 3,
  /// <summary>
  /// E-mail message.
  /// </summary>
  EMail = 4,
  /// <summary>
  /// Fax.
  /// </summary>
  Fax = 5,
  /// <summary>
  /// Not a merge document.
  /// </summary>
  NotAMergeDocument = -1
}
