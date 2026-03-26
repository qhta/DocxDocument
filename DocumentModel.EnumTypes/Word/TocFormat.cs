namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of formatting to apply to the table of contents in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtocformat?view=office-pia` for Office interop details.
/// </remarks>
public enum TocFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  Distinctive = 2,
  /// <summary>
  /// Fancy formatting.
  /// </summary>
  Fancy = 3,
  /// <summary>
  /// Modern formatting.
  /// </summary>
  Modern = 4,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  Formal = 5,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  Simple = 6
}
