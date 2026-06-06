
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis?view=office-pia"/>
public interface IAxis
{
  /// <summary>
  /// Gets or sets the `AxisBetweenCategories` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.axisbetweencategories?view=office-pia"/>
  public bool AxisBetweenCategories { get; set; }
  /// <summary>
  /// Gets the `AxisGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.axisgroup?view=office-pia"/>
  public AxisGroup AxisGroup { get; }
  /// <summary>
  /// Gets the `AxisTitle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.axistitle?view=office-pia"/>
  public IAxisTitle AxisTitle { get; }
  /// <summary>
  /// Gets or sets the `CategoryNames` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.categorynames?view=office-pia"/>
  public object CategoryNames { get; set; }
  /// <summary>
  /// Gets or sets the `Crosses` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.crosses?view=office-pia"/>
  public AxisCrosses Crosses { get; set; }
  /// <summary>
  /// Gets or sets the `CrossesAt` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.crossesat?view=office-pia"/>
  public double CrossesAt { get; set; }
  /// <summary>
  /// Gets or sets the `HasMajorGridlines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hasmajorgridlines?view=office-pia"/>
  public bool HasMajorGridlines { get; set; }
  /// <summary>
  /// Gets or sets the `HasMinorGridlines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hasminorgridlines?view=office-pia"/>
  public bool HasMinorGridlines { get; set; }
  /// <summary>
  /// Gets or sets the `HasTitle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hastitle?view=office-pia"/>
  public bool HasTitle { get; set; }
  /// <summary>
  /// Gets the `MajorGridlines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorgridlines?view=office-pia"/>
  public IGridLines MajorGridlines { get; }
  /// <summary>
  /// Gets or sets the `MajorTickMark` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majortickmark?view=office-pia"/>
  public TickMark MajorTickMark { get; set; }
  /// <summary>
  /// Gets or sets the `MajorUnit` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorunit?view=office-pia"/>
  public double MajorUnit { get; set; }
  /// <summary>
  /// Gets or sets the `LogBase` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.logbase?view=office-pia"/>
  public double LogBase { get; set; }
  /// <summary>
  /// Gets or sets the `TickLabelSpacingIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabelspacingisauto?view=office-pia"/>
  public bool TickLabelSpacingIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MajorUnitIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorunitisauto?view=office-pia"/>
  public bool MajorUnitIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MaximumScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.maximumscale?view=office-pia"/>
  public double MaximumScale { get; set; }
  /// <summary>
  /// Gets or sets the `MaximumScaleIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.maximumscaleisauto?view=office-pia"/>
  public bool MaximumScaleIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MinimumScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minimumscale?view=office-pia"/>
  public double MinimumScale { get; set; }
  /// <summary>
  /// Gets or sets the `MinimumScaleIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minimumscaleisauto?view=office-pia"/>
  public bool MinimumScaleIsAuto { get; set; }
  /// <summary>
  /// Gets the `MinorGridlines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorgridlines?view=office-pia"/>
  public IGridLines MinorGridlines { get; }
  /// <summary>
  /// Gets or sets the `MinorTickMark` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minortickmark?view=office-pia"/>
  public TickMark MinorTickMark { get; set; }
  /// <summary>
  /// Gets or sets the `MinorUnit` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorunit?view=office-pia"/>
  public double MinorUnit { get; set; }
  /// <summary>
  /// Gets or sets the `MinorUnitIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorunitisauto?view=office-pia"/>
  public bool MinorUnitIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `ReversePlotOrder` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.reverseplotorder?view=office-pia"/>
  public bool ReversePlotOrder { get; set; }
  /// <summary>
  /// Gets or sets the `ScaleType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.scaletype?view=office-pia"/>
  public ScaleType ScaleType { get; set; }
  /// <summary>
  /// Gets or sets the `TickLabelPosition` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabelposition?view=office-pia"/>
  public TickLabelPosition TickLabelPosition { get; set; }
  /// <summary>
  /// Gets the `TickLabels` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabels?view=office-pia"/>
  public ITickLabels TickLabels { get; }
  /// <summary>
  /// Gets or sets the `TickLabelSpacing` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabelspacing?view=office-pia"/>
  public int TickLabelSpacing { get; set; }
  /// <summary>
  /// Gets or sets the `TickMarkSpacing` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.tickmarkspacing?view=office-pia"/>
  public int TickMarkSpacing { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.type?view=office-pia"/>
  public AxisType Type { get; set; }
  /// <summary>
  /// Gets or sets the `BaseUnit` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.baseunit?view=office-pia"/>
  public TimeUnit BaseUnit { get; set; }
  /// <summary>
  /// Gets or sets the `BaseUnitIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.baseunitisauto?view=office-pia"/>
  public bool BaseUnitIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MajorUnitScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorunitscale?view=office-pia"/>
  public TimeUnit MajorUnitScale { get; set; }
  /// <summary>
  /// Gets or sets the `MinorUnitScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorunitscale?view=office-pia"/>
  public TimeUnit MinorUnitScale { get; set; }
  /// <summary>
  /// Gets or sets the `CategoryType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.categorytype?view=office-pia"/>
  public CategoryType CategoryType { get; set; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.left?view=office-pia"/>
  public double Left { get; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.top?view=office-pia"/>
  public double Top { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.width?view=office-pia"/>
  public double Width { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.height?view=office-pia"/>
  public double Height { get; }
  /// <summary>
  /// Gets or sets the `DisplayUnit` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.displayunit?view=office-pia"/>
  public DisplayUnit DisplayUnit { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayUnitCustom` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.displayunitcustom?view=office-pia"/>
  public double DisplayUnitCustom { get; set; }
  /// <summary>
  /// Gets or sets the `HasDisplayUnitLabel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hasdisplayunitlabel?view=office-pia"/>
  public bool HasDisplayUnitLabel { get; set; }
  /// <summary>
  /// Gets the `DisplayUnitLabel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.displayunitlabel?view=office-pia"/>
  public IDisplayUnitLabel DisplayUnitLabel { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.format?view=office-pia"/>
  public IChartFormat Format { get; }	

  #region methods	
/// <summary>
  /// Deletes the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.select?view=office-pia"/>
  public object Select();	
  #endregion methods
}	

