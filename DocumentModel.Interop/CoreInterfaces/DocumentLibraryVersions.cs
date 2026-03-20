using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of DocumentLibraryVersion objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions?view=office-pia
/// </remarks>
public partial interface DocumentLibraryVersions: InteropCollection<DocumentLibraryVersion>
{
  /// <summary>
  /// Gets the `IsVersioningEnabled` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversions.isversioningenabled?view=office-pia
  /// </remarks>
  public bool IsVersioningEnabled { get; }
}
