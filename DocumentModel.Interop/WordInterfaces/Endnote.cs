namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an endnote.
/// </summary>
public partial interface Endnote : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The reference.
  /// </summary>
  public Range Reference { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
}
