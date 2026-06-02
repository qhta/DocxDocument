using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of data labels.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels?view=office-pia"/>
public partial class MsoDataLabels
{
  /// <summary>
  /// Selects the data labels collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.select?view=office-pia"/>
  public object Select() { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the data labels collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.delete?view=office-pia"/>
  public object Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Returns an enumerator that iterates through the data labels.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator() { throw new NotImplementedException(); }
  /// <summary>
  /// Propagates data label settings.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.propagate?view=office-pia"/>
  public void Propagate(object Index) { throw new NotImplementedException(); }
}


