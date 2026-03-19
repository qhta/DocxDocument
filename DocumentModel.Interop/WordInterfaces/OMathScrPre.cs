namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that contains a superscript or subscript to the left of the base.
/// </summary>
public partial interface OMathScrPre : InteropObject
{
  /// <summary>
  /// The sub.
  /// </summary>
  public OMath Sub { get; }

  /// <summary>
  /// The sup.
  /// </summary>
  public OMath Sup { get; }

  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
}
