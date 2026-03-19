namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript or subscript.
/// </summary>
public partial interface OMathScrSubSup : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }

  /// <summary>
  /// The sub.
  /// </summary>
  public OMath Sub { get; }

  /// <summary>
  /// The sup.
  /// </summary>
  public OMath Sup { get; }

  /// <summary>
  /// The align scripts.
  /// </summary>
  public bool AlignScripts { get; set; }
}
