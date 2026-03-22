namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format for an e-mail message. These formats correspond to the formats supported by Microsoft
/// Outlook for e-mail messages.
/// </summary>
public enum MailFormat
{
  /// <summary>
  /// Plain text.
  /// </summary>
  PlainText = 1,
  /// <summary>
  /// Hypertext Markup Language (HTML) formatting.
  /// </summary>
  HTML,
  /// <summary>
  /// Rich Text Format (RTF) formatting.
  /// </summary>
  RTF
}
