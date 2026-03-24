namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the properties of the selection.
/// </summary>
public enum WdSelectionFlags
{
  /// <summary>
  /// The selection is at the start of the active document.
  /// </summary>
  StartActive = unchecked((int)1),
  /// <summary>
  /// The selection is at the end of the letter.
  /// </summary>
  AtEOL = unchecked((int)2),
  /// <summary>
  /// The selection was overtyped.
  /// </summary>
  Overtype = unchecked((int)4),
  /// <summary>
  /// The selection is the active selection.
  /// </summary>
  Active = unchecked((int)8),
  /// <summary>
  /// The selection was replaced.
  /// </summary>
  Replace = unchecked((int)16)
}
