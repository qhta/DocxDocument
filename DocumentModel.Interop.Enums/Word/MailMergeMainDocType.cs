namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mail merge document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergemaindoctype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailMergeMainDocType")]
public enum MailMergeMainDocType
{
  /// <summary>
  /// Form letter.
  /// </summary>
  [WordInteropEnumValue("wdFormLetters")]
  FormLetters = 0,
  /// <summary>
  /// Mailing label.
  /// </summary>
  [WordInteropEnumValue("wdMailingLabels")]
  MailingLabels = 1,
  /// <summary>
  /// Envelope.
  /// </summary>
  [WordInteropEnumValue("wdEnvelopes")]
  Envelopes = 2,
  /// <summary>
  /// Directory.
  /// </summary>
  [WordInteropEnumValue("wdDirectory")]
  Directory = 3,
  /// <summary>
  /// Catalog.
  /// </summary>
  [WordInteropEnumValue("wdCatalog")]
  Catalog = 3,
  /// <summary>
  /// E-mail message.
  /// </summary>
  [WordInteropEnumValue("wdEMail")]
  EMail = 4,
  /// <summary>
  /// Fax.
  /// </summary>
  [WordInteropEnumValue("wdFax")]
  Fax = 5,
  /// <summary>
  /// Not a merge document.
  /// </summary>
  [WordInteropEnumValue("wdNotAMergeDocument")]
  NotAMergeDocument = -1
}
