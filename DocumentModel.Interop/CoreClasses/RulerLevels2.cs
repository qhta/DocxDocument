using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of ruler outline levels.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2?view=office-pia"/>
public partial class RulerLevels2: InteropCollection<RulerLevel2>
{


  #region methods

/// <summary>
  /// Returns a ruler level by index.
  /// </summary>
  /// <param name="Index">The index of the ruler level to return.</param>
  /// <returns>The requested ruler level.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2.item?view=office-pia"/>
  public RulerLevel2 Item(object Index) { throw new NotImplementedException(); }

  #endregion methods
}

