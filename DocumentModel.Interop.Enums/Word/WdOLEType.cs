namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of an OLE object.
/// </summary>
public enum WdOLEType
{
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  Link = 0,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  Embed = 1,
  /// <summary>
  /// OLE control.
  /// </summary>
  Control = 2
}
