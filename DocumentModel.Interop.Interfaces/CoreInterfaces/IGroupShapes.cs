using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes?view=office-pia"/>
public interface IGroupShapes: IInteropCollection<IShape>
{


  #region methods

/// <summary>
  /// Returns a shape from the group by index or name.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes.item?view=office-pia"/>
  public IShape Item(object index);
  /// <summary>
  /// Returns a shape range from the group.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes.range?view=office-pia"/>
  public IShapeRange Range(object index);

  #endregion methods
}

