using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `GroupShapes` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes?view=office-pia` for Office interop details.
/// </remarks>
public partial interface GroupShapes
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes.item?view=office-pia
  /// </remarks>
  public Shape Item(object Index);
  /// <summary>
  /// Invokes `Range`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes.range?view=office-pia
  /// </remarks>
  public ShapeRange Range(object Index);
}
