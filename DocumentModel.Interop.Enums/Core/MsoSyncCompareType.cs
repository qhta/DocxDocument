
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how comparison between local copy and server copy should be done in a synchronization process.
/// </summary>
public enum MsoSyncCompareType
{
  /// <summary>
  /// Compare and merge versions.
  /// </summary>
  msoSyncCompareAndMerge,
  /// <summary>
  /// Compare versions side-by-side.
  /// </summary>
  msoSyncCompareSideBySide
}
