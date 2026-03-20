using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Describes a single picture effect parameter.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter?view=office-pia
/// </remarks>
public partial interface EffectParameter: InteropObject
{
  /// <summary>
  /// Gets the parameter name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Value` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter.value?view=office-pia
  /// </remarks>
  public object Value { get; set; }
}
