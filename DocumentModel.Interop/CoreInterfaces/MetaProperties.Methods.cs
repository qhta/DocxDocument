using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of metadata properties.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties?view=office-pia
/// </remarks>
public partial interface MetaProperties
{
  /// <summary>
  /// Gets a metadata property by its internal name.
  /// </summary>
  /// <param name="InternalName">The `InternalName` parameter.</param>
  /// <returns>The matching metadata property.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.getitembyinternalname?view=office-pia
  /// </remarks>
  public MetaProperty GetItemByInternalName(string InternalName);
  /// <summary>
  /// Validates all metadata properties.
  /// </summary>
  /// <returns>The validation error message, if any.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validate?view=office-pia
  /// </remarks>
  public string Validate();
}
