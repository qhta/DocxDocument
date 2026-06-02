using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single saved version of a shared document in a document library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion?view=office-pia"/>
public partial interface IDocumentLibraryVersion
{
  /// <summary>
  /// Deletes this document library version.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Opens this document library version.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.open?view=office-pia"/>
  public object Open();
  /// <summary>
  /// Restores this version as the current document version.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.restore?view=office-pia"/>
  public object Restore();
}

