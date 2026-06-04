
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and under what circumstances synchronization is available for the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncavailabletype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSyncAvailableType")]
public enum SyncAvailableType
{
  /// <summary>
  /// No synchronization is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncAvailableNone")]
  None,
  /// <summary>
  /// Synchronization is available offline only.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncAvailableOffline")]
  Offline,
  /// <summary>
  /// Synchronization is available offline and online.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncAvailableAnywhere")]
  Anywhere
}
