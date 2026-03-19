namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
public partial interface RoutingSlip : InteropObject
{
  /// <summary>
  /// The subject.
  /// </summary>
  public string Subject { get; set; }

  /// <summary>
  /// The message.
  /// </summary>
  public string Message { get; set; }

  /// <summary>
  /// The delivery.
  /// </summary>
  public WdRoutingSlipDelivery Delivery { get; set; }

  /// <summary>
  /// The track status.
  /// </summary>
  public bool TrackStatus { get; set; }

  /// <summary>
  /// The protect.
  /// </summary>
  public WdProtectionType Protect { get; set; }

  /// <summary>
  /// The return when done.
  /// </summary>
  public bool ReturnWhenDone { get; set; }

  /// <summary>
  /// The status.
  /// </summary>
  public WdRoutingSlipStatus Status { get; }
}
