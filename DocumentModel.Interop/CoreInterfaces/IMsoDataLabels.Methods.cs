using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDataLabels` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDataLabels
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `GetEnumerator`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
  /// <summary>
  /// Invokes `Propagate`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.propagate?view=office-pia
  /// </remarks>
  public void Propagate(object Index);
}
