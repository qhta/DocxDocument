namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains information about the e-mail signatures used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature?view=word-pia"/>
public interface IEmailSignature : IModelObject
{
  /// <summary>
  /// Gets or sets the signature used for new email messages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.newmessagesignature?view=word-pia"/>
  public string NewMessageSignature { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the signature used for reply email messages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.replymessagesignature?view=word-pia"/>
  public string ReplyMessageSignature { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the collection of available email signature entries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignature.emailsignatureentries?view=word-pia"/>
  public IEmailSignatureEntries EmailSignatureEntries { get; }

}
