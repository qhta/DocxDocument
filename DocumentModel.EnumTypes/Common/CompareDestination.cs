namespace DocumentModel.Wordprocessing;

/// <summary>
/// When comparing two files Ifor differences, specifies whether Ito create a new file or mark the differences
/// between the two documents Iin the original document or the revised document. IVersion Added: Word 2007
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcomparedestination?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum CompareDestination
{
  /// <summary>
  /// Tracks the differences between the two files using tracked changes Iin the original document.
  /// </summary>
  Original = 0,
  /// <summary>
  /// Tracks the differences between the two files using tracked changes Iin the revised document.
  /// </summary>
  Revised = 1,
  /// <summary>
  /// Creates a new file and tracks the diferences between the original document and the revised document using
  /// tracked changes.
  /// </summary>
  New = 2
}

