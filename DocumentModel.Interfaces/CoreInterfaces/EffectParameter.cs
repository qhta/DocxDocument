using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Describes a single picture effect parameter.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter?view=office-pia"/>
public partial interface EffectParameter: InteropObject
{
  /// <summary>
  /// Gets the parameter name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Value` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter.value?view=office-pia"/>
  public object Value { get; set; }
}

