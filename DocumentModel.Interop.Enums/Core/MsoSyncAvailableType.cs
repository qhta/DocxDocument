
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and under what circumstances synchronization is available for the document.
/// </summary>
public enum MsoSyncAvailableType
{
  /// <summary>
  /// No synchronization is available.
  /// </summary>
  None,
  /// <summary>
  /// Synchronization is available offline only.
  /// </summary>
  Offline,
  /// <summary>
  /// Synchronization is available offline and online.
  /// </summary>
  Anywhere
}
