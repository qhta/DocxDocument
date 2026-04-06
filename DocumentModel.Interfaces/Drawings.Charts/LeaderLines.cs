
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents leader lines in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia"/>
public partial interface ILeaderLines: IModelObject
{
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.format?view=office-pia"/>
  public IChartFormat Format { get; }
}

