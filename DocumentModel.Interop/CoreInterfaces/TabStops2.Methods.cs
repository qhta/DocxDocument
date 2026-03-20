using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStops2` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2?view=office-pia
/// </remarks>
public partial interface TabStops2
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.item?view=office-pia
  /// </remarks>
  public TabStop2 Item(object Index);
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.add?view=office-pia
  /// </remarks>
  public TabStop2 Add(MsoTabStopType Type, float Position);
}
