namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of index objects in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes?view=word-pia"/>
public partial interface IIndexes : IModelCollection<Index>
{
  /// <summary>
  /// Returns or sets the built-in format used for the index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes.format?view=word-pia"/>
  public IndexFormat Format { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
