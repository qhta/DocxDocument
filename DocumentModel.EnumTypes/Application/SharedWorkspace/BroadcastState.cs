namespace DocumentModel.IApplication;

/// <summary>
/// Specifies the current state of a document or presentation broadcast.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcaststate?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum BroadcastState
{
  /// <summary>
  /// The file is not being broadcasted.
  /// </summary>
  NoBroadcast,
  /// <summary>
  /// The broadcast has been started.
  /// </summary>
  BroadcastStarted,
  /// <summary>
  /// The broadcast is paused.
  /// </summary>
  BroadcastPaused
}

