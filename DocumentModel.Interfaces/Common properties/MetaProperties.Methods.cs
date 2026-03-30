using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of metadata properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties?view=office-pia"/>
public partial interface IMetaProperties: IModelObject
{
  /// <summary>
  /// Gets a metadata property by its internal name.
  /// </summary>
  /// <param name="InternalName">The `InternalName` parameter.</param>
  /// <returns>The matching metadata property.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.getitembyinternalname?view=office-pia"/>
  public IMetaProperty GetItemByInternalName(string InternalName);
  /// <summary>
  /// Validates all metadata properties.
  /// </summary>
  /// <returns>The validation error message, if any.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validate?view=office-pia"/>
  public string Validate();
}

