using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of data labels.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels?view=office-pia
/// </remarks>
public partial interface IMsoDataLabels
{
  /// <summary>
  /// Selects the data labels collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the data labels collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Returns an enumerator that iterates through the data labels.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
  /// <summary>
  /// Propagates data label settings.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.propagate?view=office-pia
  /// </remarks>
  public void Propagate(object Index);
}
