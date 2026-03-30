
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents drop lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines?view=office-pia"/>
public partial interface DropLines: IModelObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.format?view=office-pia"/>
  public ChartFormat Format { get; }
}

