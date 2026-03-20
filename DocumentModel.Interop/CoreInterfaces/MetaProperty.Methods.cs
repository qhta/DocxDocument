using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a metadata property.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty?view=office-pia
/// </remarks>
public partial interface MetaProperty
{
  /// <summary>
  /// Validates the metadata property value.
  /// </summary>
  /// <returns>The validation error message, if any.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.validate?view=office-pia
  /// </remarks>
  public string Validate();
}
