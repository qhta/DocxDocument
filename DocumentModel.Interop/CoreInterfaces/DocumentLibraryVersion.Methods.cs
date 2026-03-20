using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single saved version of a shared document in a document library.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion?view=office-pia
/// </remarks>
public partial interface DocumentLibraryVersion
{
  /// <summary>
  /// Deletes this document library version.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Opens this document library version.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.open?view=office-pia
  /// </remarks>
  public object Open();
  /// <summary>
  /// Restores this version as the current document version.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.restore?view=office-pia
  /// </remarks>
  public object Restore();
}
