using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes?view=office-pia"/>
public partial interface CanvasShapes: IModelCollection<Shape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.background?view=office-pia"/>
  public Shape Background { get; }
}

