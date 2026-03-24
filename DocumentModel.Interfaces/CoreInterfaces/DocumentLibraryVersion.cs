using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a single saved version of a shared document in a document library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion?view=office-pia"/>
public partial interface DocumentLibraryVersion: InteropObject
{
  /// <summary>
  /// Gets the `Modified` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.modified?view=office-pia"/>
  public object Modified { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `ModifiedBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.modifiedby?view=office-pia"/>
  public string ModifiedBy { get; }
  /// <summary>
  /// Gets the `Comments` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentlibraryversion.comments?view=office-pia"/>
  public string Comments { get; }
}

