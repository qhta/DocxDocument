namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a conflicting edit in a co-authored document. The type of a Conflict object is specified by the WdRevisionType enumeration.
/// </summary>
public partial interface Conflict : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdRevisionType Type { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
}
