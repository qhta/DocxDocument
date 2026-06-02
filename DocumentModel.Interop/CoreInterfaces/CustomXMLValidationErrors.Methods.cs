using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia"/>
public partial interface ICustomXMLValidationErrors
{
  /// <summary>
  /// Adds a validation error entry to the collection.
  /// </summary>
  /// <param name="Node">The `Node` parameter.</param>
  /// <param name="ErrorName">The `ErrorName` parameter.</param>
  /// <param name="ErrorText">The `ErrorText` parameter.</param>
  /// <param name="ClearedOnUpdate">The `ClearedOnUpdate` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors.add?view=office-pia"/>
  public void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
}

