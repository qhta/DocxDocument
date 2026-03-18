namespace DocumentModel.Interop;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
public interface Mailer : InteropObject
{
  /// <summary>
  /// The bccrecipients.
  /// </summary>
  public object BCCRecipients { get; set; }
  /// <summary>
  /// The ccrecipients.
  /// </summary>
  public object CCRecipients { get; set; }
  /// <summary>
  /// The recipients.
  /// </summary>
  public object Recipients { get; set; }
  /// <summary>
  /// The enclosures.
  /// </summary>
  public object Enclosures { get; set; }
  /// <summary>
  /// The sender.
  /// </summary>
  public string Sender { get; }
  /// <summary>
  /// The send date time.
  /// </summary>
  public DateTime SendDateTime { get; }
  /// <summary>
  /// The received.
  /// </summary>
  public bool Received { get; }
  /// <summary>
  /// The subject.
  /// </summary>
  public string Subject { get; set; }

}
