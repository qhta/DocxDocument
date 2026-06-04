namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a destination for mail merge results.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergedestination?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailMergeDestination")]
public enum MailMergeDestination
{
  /// <summary>
  /// Send results to a new Word document.
  /// </summary>
  [WordInteropEnumValue("wdSendToNewDocument")]
  NewDocument = 0,
  /// <summary>
  /// Send results to a printer.
  /// </summary>
  [WordInteropEnumValue("wdSendToPrinter")]
  Printer = 1,
  /// <summary>
  /// Send results to e-mail recipient.
  /// </summary>
  [WordInteropEnumValue("wdSendToEmail")]
  Email = 2,
  /// <summary>
  /// Send results to fax recipient.
  /// </summary>
  [WordInteropEnumValue("wdSendToFax")]
  Fax = 3
}
