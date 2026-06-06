namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of index objects in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes?view=word-pia"/>
public interface IIndexes : IInteropObject, IInteropCollection<IIndex>
{
  /// <summary>
  /// Returns or sets the built-in format used for the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes.format?view=word-pia"/>
  public IndexFormat Format { get; set; }


  #region methods

/// <summary>
  /// Adds an index to the document using legacy options.
  /// </summary>
  /// <param name="range">The range to which the index is added.</param>
  /// <param name="headingSeparator">The separator to use between headings.</param>
  /// <param name="rightAlignPageNumbers">true to right-align page numbers; otherwise, false.</param>
  /// <param name="type">The type of index to add.</param>
  /// <param name="numberOfColumns">The number of columns in the index.</param>
  /// <param name="accentedLetters">true to include accented letters; otherwise, false.</param>
  /// <returns>The created <see cref="IIndex"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes.addold?view=word-pia"/>
  public IIndex AddOld(IRange range, HeadingSeparator headingSeparator, bool rightAlignPageNumbers, IndexType type, int numberOfColumns, bool accentedLetters);

  #endregion methods
}
