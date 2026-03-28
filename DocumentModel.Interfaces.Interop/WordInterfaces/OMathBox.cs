namespace DocumentModel.Interop;

/// <summary>
/// Represents an invisible box around an equation or part of an equation to which you can apply properties that affect the mathematical or formatting properties, such as line breaks.
/// </summary>
public interface OMathBox : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The op emu.
  /// </summary>
  public bool OpEmu { get; set; }
  /// <summary>
  /// The no break.
  /// </summary>
  public bool NoBreak { get; set; }
  /// <summary>
  /// The diff.
  /// </summary>
  public bool Diff { get; set; }

}
