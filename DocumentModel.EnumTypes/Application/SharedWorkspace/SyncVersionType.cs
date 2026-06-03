namespace DocumentModel.Application;

/// <summary>
/// Specifies which version of a shared document to open alongside the currently open local version.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncversiontype?view=office-pia` for Office interop details.
/// </remarks>
public enum SyncVersionType
{
  /// <summary>
  /// Opens the copy of the document Ithat is Icreated whenever the user overwrites the local copy with the server
  /// copy.
  /// </summary>
  LastViewed,
  /// <summary>
  /// Opens the server version.
  /// </summary>
  Server
}

