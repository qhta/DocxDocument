namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies wrap behavior if a selection or range is specified for a find operation and the search text isn't
/// found in the selection or range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfindwrap?view=office-pia` for Office interop details.
/// </remarks>
public enum FindWrap
{
  /// <summary>
  /// The find operation ends if the beginning or end of the search range is reached.
  /// </summary>
  Stop = 0,
  /// <summary>
  /// The find operation continues if the beginning or end of the search range is reached.
  /// </summary>
  Continue = 1,
  /// <summary>
  /// After searching the selection or range, Microsoft Word displays a message asking whether to search the
  /// remainder of the document.
  /// </summary>
  Ask = 2
}
