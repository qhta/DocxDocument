namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes?view=word-pia"/>
public partial interface IIndexes : IModelObject
{
  /// <summary>
  /// Adds an index to the document using legacy options.
  /// </summary>
  /// <param name="Range">The range to which the index is added.</param>
  /// <param name="HeadingSeparator">The separator to use between headings.</param>
  /// <param name="RightAlignPageNumbers">true to right-align page numbers; otherwise, false.</param>
  /// <param name="Type">The type of index to add.</param>
  /// <param name="NumberOfColumns">The number of columns in the index.</param>
  /// <param name="AccentedLetters">true to include accented letters; otherwise, false.</param>
  /// <returns>The created <see cref="Index"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes.addold?view=word-pia"/>
  public Index AddOld(IRange Range, HeadingSeparator HeadingSeparator, bool RightAlignPageNumbers, IndexType Type, int NumberOfColumns, bool AccentedLetters);
}
