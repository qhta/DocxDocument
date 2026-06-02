using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of DocumentLibraryVersion objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions?view=office-pia"/>
public interface IDocumentLibraryVersions: IInteropCollection<IDocumentLibraryVersion>
{
  /// <summary>
  /// Gets the `IsVersioningEnabled` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions.isversioningenabled?view=office-pia"/>
  public bool IsVersioningEnabled { get; }
}

