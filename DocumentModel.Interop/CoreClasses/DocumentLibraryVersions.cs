using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of DocumentLibraryVersion objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions?view=office-pia"/>
public partial class DocumentLibraryVersions: InteropCollection<DocumentLibraryVersion>
{
  /// <summary>
  /// Gets the `IsVersioningEnabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions.isversioningenabled?view=office-pia"/>
  public bool IsVersioningEnabled { get; }
}

