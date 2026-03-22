namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the properties of the selection.
/// </summary>
public enum WdSelectionFlags
{
  /// <summary>
  /// The selection is at the start of the active document.
  /// </summary>
  wdSelStartActive = unchecked((int)1),
  /// <summary>
  /// The selection is at the end of the letter.
  /// </summary>
  wdSelAtEOL = unchecked((int)2),
  /// <summary>
  /// The selection was overtyped.
  /// </summary>
  wdSelOvertype = unchecked((int)4),
  /// <summary>
  /// The selection is the active selection.
  /// </summary>
  wdSelActive = unchecked((int)8),
  /// <summary>
  /// The selection was replaced.
  /// </summary>
  wdSelReplace = unchecked((int)16)
}
