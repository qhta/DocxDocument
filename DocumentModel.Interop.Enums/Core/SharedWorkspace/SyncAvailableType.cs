
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and under what circumstances synchronization is available for the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncavailabletype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSyncAvailableType")]
public enum SyncAvailableType
{
  /// <summary>
  /// No synchronization is available.
  /// </summary>
  [InteropEnumValue("msoSyncAvailableNone")]
  None,
  /// <summary>
  /// Synchronization is available offline only.
  /// </summary>
  [InteropEnumValue("msoSyncAvailableOffline")]
  Offline,
  /// <summary>
  /// Synchronization is available offline and online.
  /// </summary>
  [InteropEnumValue("msoSyncAvailableAnywhere")]
  Anywhere
}
