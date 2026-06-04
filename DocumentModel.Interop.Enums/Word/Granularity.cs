namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the granularity of changes to track when comparing two documents. Version Added: Word 2007.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgranularity?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdGranularity")]
public enum Granularity
{
  /// <summary>
  /// Tracks character-level changes.
  /// </summary>
  [InteropEnumValue("wdGranularityCharLevel")]
  CharLevel = 0,
  /// <summary>
  /// Tracks word-level changes.
  /// </summary>
  [InteropEnumValue("wdGranularityWordLevel")]
  WordLevel = 1
}
