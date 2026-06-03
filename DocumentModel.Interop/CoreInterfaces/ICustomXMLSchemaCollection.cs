using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of CustomXMLSchema objects attached to a data stream.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection?view=office-pia"/>
public interface ICustomXMLSchemaCollection: IInteropCollection<ICustomXMLSchema>
{
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }


  #region methods

/// <summary>
  /// Adds a schema to the custom XML schema collection.
  /// </summary>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="Alias">The `Alias` parameter.</param>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="InstallForAllUsers">The `InstallForAllUsers` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.add?view=office-pia"/>
  public ICustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);
  /// <summary>
  /// Adds all schemas from another schema collection.
  /// </summary>
  /// <param name="SchemaCollection">The `SchemaCollection` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.addcollection?view=office-pia"/>
  public void AddCollection(ICustomXMLSchemaCollection SchemaCollection);
  /// <summary>
  /// Validates the custom XML schema collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.validate?view=office-pia"/>
  public bool Validate();

  #endregion methods
}

