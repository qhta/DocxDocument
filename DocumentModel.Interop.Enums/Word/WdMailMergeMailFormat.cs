namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when the mail merge destination is an e-mail message.
/// </summary>
public enum WdMailMergeMailFormat
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
