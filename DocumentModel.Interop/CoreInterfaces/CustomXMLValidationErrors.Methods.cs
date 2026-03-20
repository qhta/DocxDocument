using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia
/// </remarks>
public partial interface CustomXMLValidationErrors
{
  /// <summary>
  /// Adds a validation error entry to the collection.
  /// </summary>
  /// <param name="Node">The `Node` parameter.</param>
  /// <param name="ErrorName">The `ErrorName` parameter.</param>
  /// <param name="ErrorText">The `ErrorText` parameter.</param>
  /// <param name="ClearedOnUpdate">The `ClearedOnUpdate` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors.add?view=office-pia
  /// </remarks>
  public void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
}
