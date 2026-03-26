namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the criteria by which Word sorts the specified index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexsortby?view=office-pia` for Office interop details.
/// </remarks>
public enum IndexSortBy
{
  /// <summary>
  /// Sort by the number of strokes in a character.
  /// </summary>
  Stroke = 0,
  /// <summary>
  /// Sort phonetically.
  /// </summary>
  Syllable = 1
}
