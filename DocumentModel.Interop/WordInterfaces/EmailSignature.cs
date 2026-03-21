namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the e-mail signatures used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature?view=word-pia"/>
public interface EmailSignature : InteropObject
{
  /// <summary>
  /// The new message signature.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.newmessagesignature?view=word-pia"/>
  public string NewMessageSignature { get; set; }
  /// <summary>
  /// The reply message signature.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.replymessagesignature?view=word-pia"/>
  public string ReplyMessageSignature { get; set; }
  /// <summary>
  /// The email signature entries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.emailsignatureentries?view=word-pia"/>
  public EmailSignatureEntries EmailSignatureEntries { get; }

}
