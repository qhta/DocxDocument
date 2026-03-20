using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single saved version of a shared document in a document library.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion?view=office-pia
/// </remarks>
public partial interface DocumentLibraryVersion: InteropObject
{
  /// <summary>
  /// Gets the `Modified` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.modified?view=office-pia
  /// </remarks>
  public object Modified { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.index?view=office-pia
  /// </remarks>
  public int Index { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.modifiedby?view=office-pia
  /// </remarks>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `Comments` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.comments?view=office-pia
  /// </remarks>
  public string Comments { get; }
}
