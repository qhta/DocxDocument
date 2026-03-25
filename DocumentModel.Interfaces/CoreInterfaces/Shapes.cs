using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes?view=office-pia"/>
public partial interface Shapes: InteropCollection<Shape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.background?view=office-pia"/>
  public Shape Background { get; }
  /// <summary>
  /// Gets the `Default` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.default?view=office-pia"/>
  public Shape Default { get; }
}

