using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MetaProperties` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MetaProperties: InteropDictionary<string, MetaProperty>
{
  /// <summary>
  /// Gets the `ValidationError` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.validationerror?view=office-pia
  /// </remarks>
  public string ValidationError { get; }
  /// <summary>
  /// Gets the `SchemaXml` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.metaproperties.schemaxml?view=office-pia
  /// </remarks>
  public string SchemaXml { get; }
}
