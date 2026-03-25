namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the selection behavior based on visual cursor movement in a right-to-left language document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdvisualselection?view=office-pia` for Office interop details.
/// </remarks>
public enum WdVisualSelection
{
  /// <summary>
  /// All selected lines are the same width.
  /// </summary>
  Block = 0,
  /// <summary>
  /// The selection wraps from line to line.
  /// </summary>
  Continuous = 1
}
