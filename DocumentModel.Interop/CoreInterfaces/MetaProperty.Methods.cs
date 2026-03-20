using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MetaProperty` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MetaProperty
{
  /// <summary>
  /// Invokes `Validate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperty.validate?view=office-pia
  /// </remarks>
  public string Validate();
}
