
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents high-low lines in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines?view=office-pia"/>
public partial interface IHiLoLines : IModelObject
{
  /// <summary>
  /// Selects the high-low lines.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Deletes the high-low lines.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.delete?view=office-pia"/>
  public void Delete();
}

