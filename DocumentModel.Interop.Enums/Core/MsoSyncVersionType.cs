namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which version of a shared document to open alongside the currently open local version.
/// </summary>
public enum MsoSyncVersionType
{
  /// <summary>
  /// Specifies which version of a shared document to open alongside the currently open local version.
  /// </summary>
  LastViewed,
  /// <summary>
  /// Opens the server version.
  /// </summary>
  Server
}
