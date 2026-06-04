namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the OLE client and OLE server roles in which a command bar control is used when two Microsoft Office
/// applications are merged.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontrololeusage?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoControlOLEUsage))]
public enum ControlOLEUsage
{
  /// <summary>
  /// Control runs on neither client nor server.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlOLEUsage.msoControlOLEUsageNeither))]
  Neither,
  /// <summary>
  /// Server-only control.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlOLEUsage.msoControlOLEUsageServer))]
  Server,
  /// <summary>
  /// Client-only control.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlOLEUsage.msoControlOLEUsageClient))]
  Client,
  /// <summary>
  /// Control runs on both client and server.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlOLEUsage.msoControlOLEUsageBoth))]
  Both
}
