namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a destination for mail merge results.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergedestination?view=office-pia` for Office interop details.
/// </remarks>
public enum MailMergeDestination
{
  /// <summary>
  /// Send results to a new Word document.
  /// </summary>
  NewDocument = 0,
  /// <summary>
  /// Send results to a printer.
  /// </summary>
  Printer = 1,
  /// <summary>
  /// Send results to e-mail recipient.
  /// </summary>
  Email = 2,
  /// <summary>
  /// Send results to fax recipient.
  /// </summary>
  Fax = 3
}
