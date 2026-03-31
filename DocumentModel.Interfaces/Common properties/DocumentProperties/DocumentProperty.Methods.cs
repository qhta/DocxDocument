namespace DocumentModel.Properties;

/// <summary>
/// Represents a custom or built-in document property.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty?view=office-pia"/>
public partial interface IDocumentProperty: IModelObject
{
  /// <summary>
  /// Deletes the document property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperty.delete?view=office-pia"/>
  public void Delete();
}

