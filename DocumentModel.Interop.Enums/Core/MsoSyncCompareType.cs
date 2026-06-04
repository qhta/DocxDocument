
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how comparison between local copy and server copy should be done in a synchronization process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosynccomparetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSyncCompareType")]
public enum SyncCompareType
{
  /// <summary>
  /// Compare and merge versions.
  /// </summary>
  [InteropEnumValue("msoSyncCompareAndMerge")]
  AndMerge,
  /// <summary>
  /// Compare versions side-by-side.
  /// </summary>
  [InteropEnumValue("msoSyncCompareSideBySide")]
  SideBySide
}
