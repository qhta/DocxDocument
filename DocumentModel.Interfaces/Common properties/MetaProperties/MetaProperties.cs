using System.Collections;

namespace DocumentModel.Properties;

/// <summary>
/// Represents a collection of metadata properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties?view=office-pia"/>
public partial interface IMetaProperties: IModelCollection<IMetaProperty>
{
  /// <summary>
  /// Gets the `ValidationError` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validationerror?view=office-pia"/>
  public string ValidationError { get; }
  /// <summary>
  /// Gets the `SchemaXml` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.schemaxml?view=office-pia"/>
  public string SchemaXml { get; }
}

