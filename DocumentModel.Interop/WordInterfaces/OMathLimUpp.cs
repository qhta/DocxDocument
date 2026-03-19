namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the upper limit mathematical construct, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
public partial interface OMathLimUpp : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }

  /// <summary>
  /// The lim.
  /// </summary>
  public OMath Lim { get; }
}
