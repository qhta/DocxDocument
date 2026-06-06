
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry?view=office-pia"/>
public interface ILegendEntry
{
  /// <summary>
  /// Gets or sets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.font?view=office-pia"/>
  public IChartFont Font { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `LegendKey` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.legendkey?view=office-pia"/>
  public ILegendKey LegendKey { get; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.left?view=office-pia"/>
  public double Left { get; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.top?view=office-pia"/>
  public double Top { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.width?view=office-pia"/>
  public double Width { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.height?view=office-pia"/>
  public double Height { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.format?view=office-pia"/>
  public IChartFormat Format { get; }	

  #region methods	
/// <summary>
  /// Deletes the legend entry.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the legend entry.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.select?view=office-pia"/>
  public object Select();	
  #endregion methods
}	

