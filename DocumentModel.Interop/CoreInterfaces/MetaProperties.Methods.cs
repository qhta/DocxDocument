using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MetaProperties` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MetaProperties
{
  /// <summary>
  /// Invokes `GetItemByInternalName`.
  /// </summary>
  /// <param name="InternalName">The `InternalName` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.getitembyinternalname?view=office-pia
  /// </remarks>
  public MetaProperty GetItemByInternalName(string InternalName);
  /// <summary>
  /// Invokes `Validate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validate?view=office-pia
  /// </remarks>
  public string Validate();
}
