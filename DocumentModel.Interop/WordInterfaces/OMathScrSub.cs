namespace DocumentModel.Interop;

/// <summary>
/// Represents an equation with a base that contains a subscript.
/// </summary>
public interface OMathScrSub : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The sub.
  /// </summary>
  public OMath Sub { get; }

}
