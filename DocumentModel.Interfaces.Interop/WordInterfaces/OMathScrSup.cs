namespace DocumentModel.Interop;

/// <summary>
/// Represents an equation with a base that contains a superscript.
/// </summary>
public interface OMathScrSup : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The sup.
  /// </summary>
  public OMath Sup { get; }

}
