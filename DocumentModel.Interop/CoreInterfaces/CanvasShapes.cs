using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes?view=office-pia
/// </remarks>
public partial interface CanvasShapes: InteropDictionary<string, Shape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.background?view=office-pia
  /// </remarks>
  public Shape Background { get; }
}
