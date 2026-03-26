namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the granularity of changes to track when comparing two documents. Version Added: Word 2007.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgranularity?view=office-pia` for Office interop details.
/// </remarks>
public enum Granularity
{
  /// <summary>
  /// Tracks character-level changes.
  /// </summary>
  CharLevel = 0,
  /// <summary>
  /// Tracks word-level changes.
  /// </summary>
  WordLevel = 1
}
