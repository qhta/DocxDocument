namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the e-mail signatures used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature?view=word-pia"/>
public interface IEmailSignature : IInteropObject
{
  /// <summary>
  /// Gets or sets the signature used for new email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.newmessagesignature?view=word-pia"/>
  public string NewMessageSignature { get; set; }
  /// <summary>
  /// Gets or sets the signature used for reply email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.replymessagesignature?view=word-pia"/>
  public string ReplyMessageSignature { get; set; }
  /// <summary>
  /// Gets the collection of available email signature entries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.emailsignatureentries?view=word-pia"/>
  public IEmailSignatureEntries IEmailSignatureEntries { get; }

}
