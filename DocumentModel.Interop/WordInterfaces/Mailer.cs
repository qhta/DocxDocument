namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer?view=word-pia"/>
public interface Mailer : InteropObject
{
  /// <summary>
  /// The bccrecipients.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.bccrecipients?view=word-pia"/>
  public object BCCRecipients { get; set; }
  /// <summary>
  /// The ccrecipients.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.ccrecipients?view=word-pia"/>
  public object CCRecipients { get; set; }
  /// <summary>
  /// The recipients.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.recipients?view=word-pia"/>
  public object Recipients { get; set; }
  /// <summary>
  /// The enclosures.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.enclosures?view=word-pia"/>
  public object Enclosures { get; set; }
  /// <summary>
  /// The sender.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.sender?view=word-pia"/>
  public string Sender { get; }
  /// <summary>
  /// The send date time.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.senddatetime?view=word-pia"/>
  public DateTime SendDateTime { get; }
  /// <summary>
  /// The received.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.received?view=word-pia"/>
  public bool Received { get; }
  /// <summary>
  /// The subject.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailer.subject?view=word-pia"/>
  public string Subject { get; set; }

}
