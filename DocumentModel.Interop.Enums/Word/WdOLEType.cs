namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of an OLE object.
/// </summary>
public enum WdOLEType
{
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  wdOLELink = unchecked((int)0),
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  wdOLEEmbed = unchecked((int)1),
  /// <summary>
  /// OLE control.
  /// </summary>
  wdOLEControl = unchecked((int)2)
}
