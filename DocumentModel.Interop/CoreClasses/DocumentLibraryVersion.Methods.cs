using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single saved version of a shared document in a document library.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion?view=office-pia"/>
public partial class DocumentLibraryVersion
{
  /// <summary>
  /// Deletes this document library version.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Opens this document library version.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.open?view=office-pia"/>
  public object Open() { throw new NotImplementedException(); }
  /// <summary>
  /// Restores this version as the current document version.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.restore?view=office-pia"/>
  public object Restore() { throw new NotImplementedException(); }
}

