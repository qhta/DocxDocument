namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that has an accent mark above the base.
/// </summary>
public interface OMathAcc : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The char.
  /// </summary>
  public short Char { get; set; }

}
