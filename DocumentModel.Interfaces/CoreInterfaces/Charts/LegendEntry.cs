
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry?view=office-pia"/>
public partial interface LegendEntry: InteropObject
{
  /// <summary>
  /// Gets or sets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.font?view=office-pia"/>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `LegendKey` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentry.legendkey?view=office-pia"/>
  public LegendKey LegendKey { get; }
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
  public ChartFormat Format { get; }
}

