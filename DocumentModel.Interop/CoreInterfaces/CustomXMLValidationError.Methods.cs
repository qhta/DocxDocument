
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single validation error in a CustomXMLValidationErrors collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror?view=office-pia
/// </remarks>
public partial interface CustomXMLValidationError
{
  /// <summary>
  /// Deletes this validation error from the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerror.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
