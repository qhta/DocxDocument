using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MetaProperty` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MetaProperty: InteropObject
{
  /// <summary>
  /// Gets or sets the `Value` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.value?view=office-pia
  /// </remarks>
  public object Value { get; set; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `IsReadOnly` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.isreadonly?view=office-pia
  /// </remarks>
  public bool IsReadOnly { get; }
  /// <summary>
  /// Gets the `IsRequired` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.isrequired?view=office-pia
  /// </remarks>
  public bool IsRequired { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.type?view=office-pia
  /// </remarks>
  public MsoMetaPropertyType Type { get; }
  /// <summary>
  /// Gets the `ValidationError` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.validationerror?view=office-pia
  /// </remarks>
  public string ValidationError { get; }
}
