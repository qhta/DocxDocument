
namespace DocumentModel.IApplication;

/// <summary>
/// Specifies how comparison between local copy and server copy should be done Iin a synchronization process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosynccomparetype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum SyncCompareType
{
  /// <summary>
  /// Compare and merge versions.
  /// </summary>
  AndMerge,
  /// <summary>
  /// Compare versions side-by-side.
  /// </summary>
  SideBySide
}

