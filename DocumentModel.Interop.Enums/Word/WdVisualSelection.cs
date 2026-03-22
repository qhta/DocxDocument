namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the selection behavior based on visual cursor movement in a right-to-left language document.
/// </summary>
public enum WdVisualSelection
{
  /// <summary>
  /// All selected lines are the same width.
  /// </summary>
  wdVisualSelectionBlock = unchecked((int)0),
  /// <summary>
  /// The selection wraps from line to line.
  /// </summary>
  wdVisualSelectionContinuous = unchecked((int)1)
}
