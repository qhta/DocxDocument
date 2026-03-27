using System.Collections;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a collection of data labels.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels?view=office-pia"/>
public partial interface DataLabels: InteropObject
{
  /// <summary>
  /// Selects the data labels collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the data labels collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Returns an enumerator that iterates through the data labels.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();
  /// <summary>
  /// Propagates data label settings.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.propagate?view=office-pia"/>
  public void Propagate(object Index);
}

