using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of metadata properties.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties?view=office-pia"/>
public partial class MetaProperties: InteropCollection<MetaProperty>
{
  /// <summary>
  /// Gets the `ValidationError` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validationerror?view=office-pia"/>
  public string ValidationError { get; }
  /// <summary>
  /// Gets the `SchemaXml` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.schemaxml?view=office-pia"/>
  public string SchemaXml { get; }


  #region methods

/// <summary>
  /// Gets a metadata property by its internal name.
  /// </summary>
  /// <param name="internalName">The `InternalName` parameter.</param>
  /// <returns>The matching metadata property.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.getitembyinternalname?view=office-pia"/>
  public MetaProperty GetItemByInternalName(string internalName) { throw new NotImplementedException(); }
  /// <summary>
  /// Validates all metadata properties.
  /// </summary>
  /// <returns>The validation error message, if any.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validate?view=office-pia"/>
  public string Validate() { throw new NotImplementedException(); }

  #endregion methods
}

