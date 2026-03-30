
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a data label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel?view=office-pia"/>
public partial interface DataLabel: IModelObject
{
  /// <summary>
  /// Selects the data label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the data label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.delete?view=office-pia"/>
  public object Delete();
}

