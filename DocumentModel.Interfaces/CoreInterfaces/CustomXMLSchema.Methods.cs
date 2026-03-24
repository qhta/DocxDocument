
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a schema in a custom XML schema collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema?view=office-pia"/>
public partial interface CustomXMLSchema
{
  /// <summary>
  /// Deletes the schema from the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Reloads the schema from its source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.reload?view=office-pia"/>
  public void Reload();
}

