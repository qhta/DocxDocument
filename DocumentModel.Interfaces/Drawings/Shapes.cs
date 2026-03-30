using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes?view=office-pia"/>
public partial interface IShapes: IModelCollection<IShape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.background?view=office-pia"/>
  public IShape Background { get; }
  /// <summary>
  /// Gets the `Default` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.default?view=office-pia"/>
  public IShape Default { get; }
}

