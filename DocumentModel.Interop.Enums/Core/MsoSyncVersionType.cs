namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which version of a shared document to open alongside the currently open local version.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncversiontype?view=office-pia` for Office interop details.
/// </remarks>
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
