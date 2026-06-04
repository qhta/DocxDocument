namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the current state of a document or presentation broadcast.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcaststate?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBroadcastState")]
public enum BroadcastState
{
  /// <summary>
  /// The file is not being broadcasted.
  /// </summary>
  [OfficeInteropEnumValue("NoBroadcast")]
  NoBroadcast,
  /// <summary>
  /// The broadcast has been started.
  /// </summary>
  [OfficeInteropEnumValue("BroadcastStarted")]
  BroadcastStarted,
  /// <summary>
  /// The broadcast is paused.
  /// </summary>
  [OfficeInteropEnumValue("BroadcastPaused")]
  BroadcastPaused
}
