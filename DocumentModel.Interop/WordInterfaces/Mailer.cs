namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer?view=word-pia"/>
public interface Mailer : InteropObject
{
  /// <summary>
  /// The bccrecipients.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.bccrecipients?view=word-pia"/>
  public object BCCRecipients { get; set; }
  /// <summary>
  /// The ccrecipients.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.ccrecipients?view=word-pia"/>
  public object CCRecipients { get; set; }
  /// <summary>
  /// The recipients.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.recipients?view=word-pia"/>
  public object Recipients { get; set; }
  /// <summary>
  /// The enclosures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.enclosures?view=word-pia"/>
  public object Enclosures { get; set; }
  /// <summary>
  /// The sender.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.sender?view=word-pia"/>
  public string Sender { get; }
  /// <summary>
  /// The send date time.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.senddatetime?view=word-pia"/>
  public DateTime SendDateTime { get; }
  /// <summary>
  /// The received.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.received?view=word-pia"/>
  public bool Received { get; }
  /// <summary>
  /// The subject.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.subject?view=word-pia"/>
  public string Subject { get; set; }

}
