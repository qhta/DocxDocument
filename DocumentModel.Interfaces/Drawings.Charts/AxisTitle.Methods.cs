
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart axis title.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle?view=office-pia"/>
public partial interface IAxisTitle: IModelObject
{
  /// <summary>
  /// Deletes the axis title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.delete?view=office-pia"/>
  public new object Delete();
  /// <summary>
  /// Selects the axis title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.select?view=office-pia"/>
  public new object Select();
}

