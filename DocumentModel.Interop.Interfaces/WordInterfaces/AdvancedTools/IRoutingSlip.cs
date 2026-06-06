namespace DocumentModel.Interop.Word;

/// <summary>
/// A Microsoft Word routing slip was a legacy feature that allowed users to automatically email a document
/// to a list of reviewers, either sequentially (one after another) or all at once.
/// It originated in older versions (like Word 2003) and was primarily used for document approvals.
/// </summary>
/// <remarks>
/// This built-in feature was deprecated and removed in later versions of Microsoft Office because modern email clients
/// and cloud collaboration made it obsolete.Instead of routing slips, you can use modern Microsoft Office workflows:
/// <list type="bullet">
/// <item>
/// <term>Cloud Co-authoring</term>
/// <description>Save your file to OneDrive or SharePoint and share a single link. Everyone can edit and leave comments in real-time, eliminating the need to pass a single file around.</description>
/// </item>
/// <item>
/// <term>Modern Comments &amp; @mentions</term>
/// <description>Type @Name within a comment to notify a specific team member about a section needing their attention.</description>
/// </item>
/// <item>
/// <term>Power Automate</term>
/// <description>For complex, automated approval tracking, you can create customized workflows using Microsoft Power Automate.</description>
/// </item>
/// </list>
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip?view=word-pia"/>
public interface IRoutingSlip : IInteropObject
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.subject?view=word-pia"/>
  public string Subject { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.message?view=word-pia"/>
  public string Message { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.delivery?view=word-pia"/>
  public RoutingSlipDelivery Delivery { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.trackstatus?view=word-pia"/>
  public bool TrackStatus { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.protect?view=word-pia"/>
  public ProtectionType Protect { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.returnwhendone?view=word-pia"/>
  public bool ReturnWhenDone { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.status?view=word-pia"/>
  public RoutingSlipStatus Status { get; }


  #region methods

/// <summary>
  /// Returns the recipients of the routing slip at the specified index.
  /// </summary>
  /// <param name="index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.recipients?view=word-pia"/>
  public object Recipients(object index);

  #endregion methods
}
