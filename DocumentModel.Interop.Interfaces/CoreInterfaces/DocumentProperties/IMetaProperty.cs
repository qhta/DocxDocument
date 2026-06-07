using System.Reflection;	
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents a metadata property.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty?view=office-pia"/>
public interface IMetaProperty: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Value` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.value?view=office-pia"/>
  public object Value { get; set; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `IsReadOnly` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.isreadonly?view=office-pia"/>
  public bool IsReadOnly { get; }
  /// <summary>
  /// Gets the `IsRequired` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.isrequired?view=office-pia"/>
  public bool IsRequired { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.type?view=office-pia"/>
  public MetaPropertyType Type { get; }
  /// <summary>
  /// Gets the `ValidationError` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.validationerror?view=office-pia"/>
  public string ValidationError { get; }	

  #region methods	
/// <summary>
  /// Validates the metadata property value.
  /// </summary>
  /// <returns>The validation error message, if any.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.validate?view=office-pia"/>
  public string Validate();	
  #endregion methods
}	
