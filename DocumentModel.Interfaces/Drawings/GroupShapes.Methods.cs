using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes?view=office-pia"/>
public partial interface IGroupShapes: IModelObject
{
  /// <summary>
  /// Returns a shape from the group by index or name.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes.item?view=office-pia"/>
  public IShape Item(object Index);
  /// <summary>
  /// Returns a shape range from the group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes.range?view=office-pia"/>
  public IShapeRange Range(object Index);
}

