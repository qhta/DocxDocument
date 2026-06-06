
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart data table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable?view=office-pia"/>
public interface IDataTable
{
  /// <summary>
  /// Gets or sets the `ShowLegendKey` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.showlegendkey?view=office-pia"/>
  public bool ShowLegendKey { get; set; }
  /// <summary>
  /// Gets or sets the `HasBorderHorizontal` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.hasborderhorizontal?view=office-pia"/>
  public bool HasBorderHorizontal { get; set; }
  /// <summary>
  /// Gets or sets the `HasBorderVertical` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.hasbordervertical?view=office-pia"/>
  public bool HasBorderVertical { get; set; }
  /// <summary>
  /// Gets or sets the `HasBorderOutline` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.hasborderoutline?view=office-pia"/>
  public bool HasBorderOutline { get; set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.font?view=office-pia"/>
  public IChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.format?view=office-pia"/>
  public IChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Deletes the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.delete?view=office-pia"/>
  public void Delete();

  #endregion methods
}


