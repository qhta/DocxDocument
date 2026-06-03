
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend?view=office-pia"/>
public interface IMsoLegend
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.font?view=office-pia"/>
  public IChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.position?view=office-pia"/>
  public LegendPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.shadow?view=office-pia"/>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.height?view=office-pia"/>
  public double Height { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.interior?view=office-pia"/>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.fill?view=office-pia"/>
  public IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.left?view=office-pia"/>
  public double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.top?view=office-pia"/>
  public double Top { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.width?view=office-pia"/>
  public double Width { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.includeinlayout?view=office-pia"/>
  public bool IncludeInLayout { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.format?view=office-pia"/>
  public IMsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Returns legend entries.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.legendentries?view=office-pia"/>
  public object LegendEntries(object index);
  /// <summary>
  /// Clears the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.clear?view=office-pia"/>
  public object Clear();

  #endregion methods
}

