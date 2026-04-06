
namespace DocumentModel.CustomXml;

/// <summary>
/// Represents a single validation error in a CustomXMLValidationErrors collection.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia"/>
public partial interface ICustomXMLValidationError: IModelObject
{
  /// <summary>
  /// Deletes this validation error from the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.delete?view=office-pia"/>
  public void Delete();
}

