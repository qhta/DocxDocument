namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single version of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version?view=word-pia"/>
public partial interface Version : InteropObject
{
  /// <summary>
  /// Returns the saved by.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.savedby?view=word-pia"/>
  public string SavedBy { get; }

  /// <summary>
  /// Returns the comment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.comment?view=word-pia"/>
  public string Comment { get; }

  /// <summary>
  /// Returns the date.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.index?view=word-pia"/>
  public int Index { get; }
}
