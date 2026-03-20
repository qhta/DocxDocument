using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Shapes` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Shapes: InteropDictionary<string, Shape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.background?view=office-pia
  /// </remarks>
  public Shape Background { get; }
  /// <summary>
  /// Gets the `Default` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.default?view=office-pia
  /// </remarks>
  public Shape Default { get; }
}
