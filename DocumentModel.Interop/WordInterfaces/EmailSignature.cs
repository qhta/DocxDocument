namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the e-mail signatures used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
public interface EmailSignature : InteropObject
{
  /// <summary>
  /// The new message signature.
  /// </summary>
  public string NewMessageSignature { get; set; }
  /// <summary>
  /// The reply message signature.
  /// </summary>
  public string ReplyMessageSignature { get; set; }
  /// <summary>
  /// The email signature entries.
  /// </summary>
  public EmailSignatureEntries EmailSignatureEntries { get; }

}
