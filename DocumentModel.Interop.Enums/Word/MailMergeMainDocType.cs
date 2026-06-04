namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mail merge document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergemaindoctype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType))]
public enum MailMergeMainDocType
{
  /// <summary>
  /// Form letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdFormLetters))]
  FormLetters = 0,
  /// <summary>
  /// Mailing label.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdMailingLabels))]
  MailingLabels = 1,
  /// <summary>
  /// Envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdEnvelopes))]
  Envelopes = 2,
  /// <summary>
  /// Directory.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdDirectory))]
  Directory = 3,
  /// <summary>
  /// Catalog.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdCatalog))]
  Catalog = 3,
  /// <summary>
  /// E-mail message.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdEMail))]
  EMail = 4,
  /// <summary>
  /// Fax.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdFax))]
  Fax = 5,
  /// <summary>
  /// Not a merge document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdNotAMergeDocument))]
  NotAMergeDocument = -1
}
