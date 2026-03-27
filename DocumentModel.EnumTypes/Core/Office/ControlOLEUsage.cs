namespace DocumentModel.Application;

/// <summary>
/// Specifies the OLE client and OLE server roles in which a command bar control is used when two Microsoft Office
/// applications are merged.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontrololeusage?view=office-pia` for Office interop details.
/// </remarks>
public enum ControlOLEUsage
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
