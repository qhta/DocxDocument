namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the current state of a document or presentation broadcast.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcaststate?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBroadcastState")]
public enum BroadcastState
{
  /// <summary>
  /// The file is not being broadcasted.
  /// </summary>
  [InteropEnumValue("NoBroadcast")]
  NoBroadcast,
  /// <summary>
  /// The broadcast has been started.
  /// </summary>
  [InteropEnumValue("BroadcastStarted")]
  BroadcastStarted,
  /// <summary>
  /// The broadcast is paused.
  /// </summary>
  [InteropEnumValue("BroadcastPaused")]
  BroadcastPaused
}
