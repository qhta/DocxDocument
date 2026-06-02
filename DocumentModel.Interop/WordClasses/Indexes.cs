namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of index objects in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes?view=word-pia"/>
public partial class Indexes : InteropCollection<Index>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.indexes.addold?view=word-pia"/>
  public Index AddOld(Range Range, HeadingSeparator HeadingSeparator, bool RightAlignPageNumbers, IndexType Type, int NumberOfColumns, bool AccentedLetters) { throw new NotImplementedException(); }

  #endregion methods
}
