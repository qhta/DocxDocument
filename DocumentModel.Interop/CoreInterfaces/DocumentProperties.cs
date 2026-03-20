using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of DocumentProperty objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties?view=office-pia
/// </remarks>
public partial interface DocumentProperties: IEnumerable
{
  /// <summary>
  /// Gets a document property by index or name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.item?view=office-pia
  /// </remarks>
  public DocumentProperty this[object Index] { get; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.count?view=office-pia
  /// </remarks>
  public int Count { get; }
}
