namespace DocumentModel.Interop;

/// <summary>
/// Represents the lower limit mathematical construct, consisting of text on the baseline and reduced-size text immediately below it.
/// </summary>
public partial interface OMathLimLow : InteropObject
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
