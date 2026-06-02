
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLSchema` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a schema in a custom XML schema collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema?view=office-pia"/>
public interface ICustomXMLSchema: IInteropObject
{
  /// <summary>
  /// Gets the `Location` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.location?view=office-pia"/>
  public string Location { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }


  #region methods

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

  #endregion methods
}

