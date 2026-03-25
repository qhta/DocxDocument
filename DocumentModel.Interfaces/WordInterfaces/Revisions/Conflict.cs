namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a conflicting edit in a co-authored document. The type of a Conflict object is specified by the WdRevisionType enumeration.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict?view=word-pia"/>
public partial interface Conflict : InteropObject
{
  /// <summary>
  /// Gets the range in the document where the conflict occurs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Gets the revision type of the conflict.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.type?view=word-pia"/>
  public WdRevisionType Type { get; }

  /// <summary>
  /// Gets the index number of the conflict in the conflicts collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.index?view=word-pia"/>
  public int Index { get; }
}
