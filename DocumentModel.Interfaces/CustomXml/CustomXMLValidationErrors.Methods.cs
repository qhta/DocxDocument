using System.Collections;

namespace DocumentModel.CustomXml;

/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia"/>
public partial interface ICustomXMLValidationErrors: IModelObject
{
  /// <summary>
  /// Adds a validation error entry to the collection.
  /// </summary>
  /// <param name="Node">The `Node` parameter.</param>
  /// <param name="ErrorName">The `ErrorName` parameter.</param>
  /// <param name="ErrorText">The `ErrorText` parameter.</param>
  /// <param name="ClearedOnUpdate">The `ClearedOnUpdate` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors.add?view=office-pia"/>
  public void Add(ICustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
}

