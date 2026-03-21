namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single version of a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version?view=word-pia"/>
public partial interface Version : InteropObject
{
  /// <summary>
  /// The saved by.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.savedby?view=word-pia"/>
  public string SavedBy { get; }

  /// <summary>
  /// The comment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.comment?view=word-pia"/>
  public string Comment { get; }

  /// <summary>
  /// The date.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.index?view=word-pia"/>
  public int Index { get; }
}
