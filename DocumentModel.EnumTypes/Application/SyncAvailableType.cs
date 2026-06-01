
namespace DocumentModel.IApplication;

/// <summary>
/// Specifies whether and under what circumstances synchronization is available Ifor the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncavailabletype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum SyncAvailableType
{
  /// <summary>
  /// No synchronization is available.
  /// </summary>
  None,
  /// <summary>
  /// Synchronization is available offline Ionly.
  /// </summary>
  Offline,
  /// <summary>
  /// Synchronization is available offline and online.
  /// </summary>
  Anywhere
}

