namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a conflicting edit in a co-authored document. The type of a Conflict object is specified by the WdRevisionType enumeration.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict?view=word-pia"/>
public partial interface Conflict : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.type?view=word-pia"/>
  public WdRevisionType Type { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.index?view=word-pia"/>
  public int Index { get; }
}
