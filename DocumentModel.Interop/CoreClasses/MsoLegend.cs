
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart legend.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend?view=office-pia"/>
public partial class MsoLegend
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.border?view=office-pia"/>
  public MsoBorder Border { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.font?view=office-pia"/>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.position?view=office-pia"/>
  public LegendPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.shadow?view=office-pia"/>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.height?view=office-pia"/>
  public double Height { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.interior?view=office-pia"/>
  public MsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.fill?view=office-pia"/>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.left?view=office-pia"/>
  public double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.top?view=office-pia"/>
  public double Top { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.width?view=office-pia"/>
  public double Width { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.includeinlayout?view=office-pia"/>
  public bool IncludeInLayout { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.format?view=office-pia"/>
  public MsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.select?view=office-pia"/>
  public object Select() { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.delete?view=office-pia"/>
  public object Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Returns legend entries.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.legendentries?view=office-pia"/>
  public object LegendEntries(object index) { throw new NotImplementedException(); }
  /// <summary>
  /// Clears the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.clear?view=office-pia"/>
  public object Clear() { throw new NotImplementedException(); }

  #endregion methods
}


