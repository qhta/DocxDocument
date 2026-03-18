namespace DocumentModel.Interop;

public partial interface Indexes
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
  public Index AddOld(Range Range, WdHeadingSeparator HeadingSeparator, bool RightAlignPageNumbers, WdIndexType Type, int NumberOfColumns, bool AccentedLetters);
}
