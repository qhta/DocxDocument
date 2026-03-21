namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip?view=word-pia"/>
public partial interface RoutingSlip : InteropObject
{
  /// <summary>
  /// The subject.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.subject?view=word-pia"/>
  public string Subject { get; set; }

  /// <summary>
  /// The message.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.message?view=word-pia"/>
  public string Message { get; set; }

  /// <summary>
  /// The delivery.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.delivery?view=word-pia"/>
  public WdRoutingSlipDelivery Delivery { get; set; }

  /// <summary>
  /// The track status.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.trackstatus?view=word-pia"/>
  public bool TrackStatus { get; set; }

  /// <summary>
  /// The protect.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.protect?view=word-pia"/>
  public WdProtectionType Protect { get; set; }

  /// <summary>
  /// The return when done.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.returnwhendone?view=word-pia"/>
  public bool ReturnWhenDone { get; set; }

  /// <summary>
  /// The status.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.status?view=word-pia"/>
  public WdRoutingSlipStatus Status { get; }
}
