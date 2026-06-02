namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a conflicting edit in a co-authored document. The type of a Conflict object is specified by the RevisionType enumeration.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict?view=word-pia"/>
public partial class Conflict : InteropObject
{
  /// <summary>
  /// Gets the range in the document where the conflict occurs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.range?view=word-pia"/>
  public Range Range { get; set; }

  /// <summary>
  /// Gets the revision type of the conflict.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.type?view=word-pia"/>
  public RevisionType Type { get; set; }

  /// <summary>
  /// Gets the index number of the conflict in the conflicts collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.index?view=word-pia"/>
  public int Index { get; set; }


  #region methods

/// <summary>
  /// Accepts the user specified conflict change, removes the conflict, and merges the change into the server copy
  /// of the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflict.accept?view=word-pia"/>
  public void Accept() { throw new NotImplementedException(); }

  #endregion methods
}
