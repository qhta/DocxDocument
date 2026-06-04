namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the selection behavior based on visual cursor movement in a right-to-left language document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdvisualselection?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdVisualSelection))]
public enum VisualSelection
{
  /// <summary>
  /// All selected lines are the same width.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdVisualSelection.wdVisualSelectionBlock))]
  Block = 0,
  /// <summary>
  /// The selection wraps from line to line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdVisualSelection.wdVisualSelectionContinuous))]
  Continuous = 1
}
