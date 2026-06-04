namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a destination for mail merge results.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergedestination?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMailMergeDestination")]
public enum MailMergeDestination
{
  /// <summary>
  /// Send results to a new Word document.
  /// </summary>
  [InteropEnumValue("wdSendToNewDocument")]
  NewDocument = 0,
  /// <summary>
  /// Send results to a printer.
  /// </summary>
  [InteropEnumValue("wdSendToPrinter")]
  Printer = 1,
  /// <summary>
  /// Send results to e-mail recipient.
  /// </summary>
  [InteropEnumValue("wdSendToEmail")]
  Email = 2,
  /// <summary>
  /// Send results to fax recipient.
  /// </summary>
  [InteropEnumValue("wdSendToFax")]
  Fax = 3
}
