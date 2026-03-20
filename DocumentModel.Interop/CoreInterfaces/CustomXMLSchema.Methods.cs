
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a schema in a custom XML schema collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema?view=office-pia
/// </remarks>
public partial interface CustomXMLSchema
{
  /// <summary>
  /// Deletes the schema from the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Reloads the schema from its source.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.reload?view=office-pia
  /// </remarks>
  public void Reload();
}
