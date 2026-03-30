using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a metadata property.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty?view=office-pia"/>
public partial interface IMetaProperty: IModelObject
{
  /// <summary>
  /// Validates the metadata property value.
  /// </summary>
  /// <returns>The validation error message, if any.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.validate?view=office-pia"/>
  public string Validate();
}

