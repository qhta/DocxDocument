namespace DocumentModel.Interop;

/// <summary>
/// Represents a group character object, consisting of a character drawn above or below text, often with the purpose of visually grouping items.
/// </summary>
public interface OMathGroupChar : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The char.
  /// </summary>
  public short Char { get; set; }
  /// <summary>
  /// The char top.
  /// </summary>
  public bool CharTop { get; set; }
  /// <summary>
  /// The align top.
  /// </summary>
  public bool AlignTop { get; set; }

}
