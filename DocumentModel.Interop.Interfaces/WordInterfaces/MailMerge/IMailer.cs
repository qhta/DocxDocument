namespace DocumentModel.Interop.Word;	
/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer?view=word-pia"/>
public interface IMailer : IInteropObject
{
  /// <summary>
  /// Returns or sets the BCC recipients for the mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.bccrecipients?view=word-pia"/>
  public object BCCRecipients { get; set; }
  /// <summary>
  /// Returns or sets the CC recipients for the mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.ccrecipients?view=word-pia"/>
  public object CCRecipients { get; set; }
  /// <summary>
  /// Returns or sets the recipients of the mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.recipients?view=word-pia"/>
  public object Recipients { get; set; }
  /// <summary>
  /// Returns or sets the enclosures for the mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.enclosures?view=word-pia"/>
  public object Enclosures { get; set; }
  /// <summary>
  /// Returns the sender of the mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.sender?view=word-pia"/>
  public string Sender { get; }
  /// <summary>
  /// Returns the date and time when the mail message was sent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.senddatetime?view=word-pia"/>
  public DateTime SendDateTime { get; }
  /// <summary>
  /// Returns whether the mail message has been received.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.received?view=word-pia"/>
  public bool Received { get; }
  /// <summary>
  /// Returns or sets the subject of the mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.subject?view=word-pia"/>
  public string Subject { get; set; }	
}
