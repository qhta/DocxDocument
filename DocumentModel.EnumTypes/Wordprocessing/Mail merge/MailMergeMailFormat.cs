namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the format to use when the mail merge destination is an e-mail message.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergemailformat?view=office-pia` for Office interop details.
/// </remarks>
public enum MailMergeMailFormat
{
  /// <summary>
  /// Sends mail merge e-mail documents using plain text.
  /// </summary>
  PlainText = 0,
  /// <summary>
  /// Sends mail merge e-mail documents using HTML format.
  /// </summary>
  HTML = 1
}
