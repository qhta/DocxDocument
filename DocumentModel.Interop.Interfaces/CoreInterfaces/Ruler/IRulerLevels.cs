using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of ruler outline levels.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2?view=office-pia"/>
public interface IRulerLevels: IInteropCollection<IRulerLevel>
{


  #region methods

/// <summary>
  /// Returns a ruler level by index.
  /// </summary>
  /// <param name="index">The index of the ruler level to return.</param>
  /// <returns>The requested ruler level.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2.item?view=office-pia"/>
  public IRulerLevel Item(object index);

  #endregion methods
}

