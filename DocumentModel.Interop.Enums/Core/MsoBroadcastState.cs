namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the current state of a document or presentation broadcast.
/// </summary>
public enum MsoBroadcastState
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
