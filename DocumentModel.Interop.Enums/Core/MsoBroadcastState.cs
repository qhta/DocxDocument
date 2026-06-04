namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the current state of a document or presentation broadcast.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcaststate?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBroadcastState))]
public enum BroadcastState
{
  /// <summary>
  /// The file is not being broadcasted.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBroadcastState.NoBroadcast))]
  NoBroadcast,
  /// <summary>
  /// The broadcast has been started.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBroadcastState.BroadcastStarted))]
  BroadcastStarted,
  /// <summary>
  /// The broadcast is paused.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBroadcastState.BroadcastPaused))]
  BroadcastPaused
}
