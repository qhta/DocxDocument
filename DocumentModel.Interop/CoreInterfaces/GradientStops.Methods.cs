using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of GradientStop objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops?view=office-pia
/// </remarks>
public partial interface GradientStops
{
  /// <summary>
  /// Deletes a gradient stop from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops.delete?view=office-pia
  /// </remarks>
  public void Delete(int Index);
  /// <summary>
  /// Inserts a gradient stop in the collection.
  /// </summary>
  /// <param name="RGB">The `RGB` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <param name="Transparency">The `Transparency` parameter.</param>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops.insert?view=office-pia
  /// </remarks>
  public void Insert(int RGB, float Position, float Transparency, int Index);
  /// <summary>
  /// Inserts a gradient stop with brightness information.
  /// </summary>
  /// <param name="RGB">The `RGB` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <param name="Transparency">The `Transparency` parameter.</param>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="Brightness">The `Brightness` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops.insert2?view=office-pia
  /// </remarks>
  public void Insert2(int RGB, float Position, float Transparency, int Index, float Brightness);
}
