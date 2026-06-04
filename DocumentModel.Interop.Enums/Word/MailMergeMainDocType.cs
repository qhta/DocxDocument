namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mail merge document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergemaindoctype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMailMergeMainDocType")]
public enum MailMergeMainDocType
{
  /// <summary>
  /// Form letter.
  /// </summary>
  [InteropEnumValue("wdFormLetters")]
  FormLetters = 0,
  /// <summary>
  /// Mailing label.
  /// </summary>
  [InteropEnumValue("wdMailingLabels")]
  MailingLabels = 1,
  /// <summary>
  /// Envelope.
  /// </summary>
  [InteropEnumValue("wdEnvelopes")]
  Envelopes = 2,
  /// <summary>
  /// Directory.
  /// </summary>
  [InteropEnumValue("wdDirectory")]
  Directory = 3,
  /// <summary>
  /// Catalog.
  /// </summary>
  [InteropEnumValue("wdCatalog")]
  Catalog = 3,
  /// <summary>
  /// E-mail message.
  /// </summary>
  [InteropEnumValue("wdEMail")]
  EMail = 4,
  /// <summary>
  /// Fax.
  /// </summary>
  [InteropEnumValue("wdFax")]
  Fax = 5,
  /// <summary>
  /// Not a merge document.
  /// </summary>
  [InteropEnumValue("wdNotAMergeDocument")]
  NotAMergeDocument = -1
}
