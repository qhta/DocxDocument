using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of DocumentProperty objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties?view=office-pia"/>
public partial interface DocumentProperties: IEnumerable
{
  /// <summary>
  /// Gets a document property by index or name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.item?view=office-pia"/>
  public DocumentProperty this[object Index] { get; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.count?view=office-pia"/>
  public int Count { get; }
}

