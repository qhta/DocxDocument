namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement for an OLE object.
/// </summary>
public enum WdOLEPlacement
{
  /// <summary>
  /// In line with text.
  /// </summary>
  wdInLine = unchecked((int)0),
  /// <summary>
  /// Float over text.
  /// </summary>
  wdFloatOverText = unchecked((int)1)
}
