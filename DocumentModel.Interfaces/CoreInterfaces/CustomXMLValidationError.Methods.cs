
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a single validation error in a CustomXMLValidationErrors collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia"/>
public partial interface CustomXMLValidationError
{
  /// <summary>
  /// Deletes this validation error from the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.delete?view=office-pia"/>
  public void Delete();
}

