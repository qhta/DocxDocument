namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the OLE client and OLE server roles in which a command bar control is used when two Microsoft Office
/// applications are merged.
/// </summary>
public enum MsoControlOLEUsage
{
  /// <summary>
  /// Control runs on neither client nor server.
  /// </summary>
  Neither,
  /// <summary>
  /// Server-only control.
  /// </summary>
  Server,
  /// <summary>
  /// Client-only control.
  /// </summary>
  Client,
  /// <summary>
  /// Control runs on both client and server.
  /// </summary>
  Both
}
