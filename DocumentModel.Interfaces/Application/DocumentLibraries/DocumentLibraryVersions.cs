using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of DocumentLibraryVersion objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions?view=office-pia"/>
public partial interface IDocumentLibraryVersions: IModelCollection<IDocumentLibraryVersion>
{
  /// <summary>
  /// Gets the `IsVersioningEnabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions.isversioningenabled?view=office-pia"/>
  public bool IsVersioningEnabled { get; }
}

