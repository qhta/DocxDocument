
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoAxis` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoAxis
{
  /// <summary>
  /// Gets or sets the `AxisBetweenCategories` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.axisbetweencategories?view=office-pia
  /// </remarks>
  public bool AxisBetweenCategories { get; set; }
  /// <summary>
  /// Gets the `AxisGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.axisgroup?view=office-pia
  /// </remarks>
  public XlAxisGroup AxisGroup { get; }
  /// <summary>
  /// Gets the `AxisTitle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.axistitle?view=office-pia
  /// </remarks>
  public IMsoAxisTitle AxisTitle { get; }
  /// <summary>
  /// Gets or sets the `CategoryNames` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.categorynames?view=office-pia
  /// </remarks>
  public object CategoryNames { get; set; }
  /// <summary>
  /// Gets or sets the `Crosses` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.crosses?view=office-pia
  /// </remarks>
  public XlAxisCrosses Crosses { get; set; }
  /// <summary>
  /// Gets or sets the `CrossesAt` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.crossesat?view=office-pia
  /// </remarks>
  public double CrossesAt { get; set; }
  /// <summary>
  /// Gets or sets the `HasMajorGridlines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hasmajorgridlines?view=office-pia
  /// </remarks>
  public bool HasMajorGridlines { get; set; }
  /// <summary>
  /// Gets or sets the `HasMinorGridlines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hasminorgridlines?view=office-pia
  /// </remarks>
  public bool HasMinorGridlines { get; set; }
  /// <summary>
  /// Gets or sets the `HasTitle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hastitle?view=office-pia
  /// </remarks>
  public bool HasTitle { get; set; }
  /// <summary>
  /// Gets the `MajorGridlines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorgridlines?view=office-pia
  /// </remarks>
  public GridLines MajorGridlines { get; }
  /// <summary>
  /// Gets or sets the `MajorTickMark` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majortickmark?view=office-pia
  /// </remarks>
  public XlTickMark MajorTickMark { get; set; }
  /// <summary>
  /// Gets or sets the `MajorUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorunit?view=office-pia
  /// </remarks>
  public double MajorUnit { get; set; }
  /// <summary>
  /// Gets or sets the `LogBase` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.logbase?view=office-pia
  /// </remarks>
  public double LogBase { get; set; }
  /// <summary>
  /// Gets or sets the `TickLabelSpacingIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabelspacingisauto?view=office-pia
  /// </remarks>
  public bool TickLabelSpacingIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MajorUnitIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorunitisauto?view=office-pia
  /// </remarks>
  public bool MajorUnitIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MaximumScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.maximumscale?view=office-pia
  /// </remarks>
  public double MaximumScale { get; set; }
  /// <summary>
  /// Gets or sets the `MaximumScaleIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.maximumscaleisauto?view=office-pia
  /// </remarks>
  public bool MaximumScaleIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MinimumScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minimumscale?view=office-pia
  /// </remarks>
  public double MinimumScale { get; set; }
  /// <summary>
  /// Gets or sets the `MinimumScaleIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minimumscaleisauto?view=office-pia
  /// </remarks>
  public bool MinimumScaleIsAuto { get; set; }
  /// <summary>
  /// Gets the `MinorGridlines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorgridlines?view=office-pia
  /// </remarks>
  public GridLines MinorGridlines { get; }
  /// <summary>
  /// Gets or sets the `MinorTickMark` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minortickmark?view=office-pia
  /// </remarks>
  public XlTickMark MinorTickMark { get; set; }
  /// <summary>
  /// Gets or sets the `MinorUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorunit?view=office-pia
  /// </remarks>
  public double MinorUnit { get; set; }
  /// <summary>
  /// Gets or sets the `MinorUnitIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorunitisauto?view=office-pia
  /// </remarks>
  public bool MinorUnitIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `ReversePlotOrder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.reverseplotorder?view=office-pia
  /// </remarks>
  public bool ReversePlotOrder { get; set; }
  /// <summary>
  /// Gets or sets the `ScaleType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.scaletype?view=office-pia
  /// </remarks>
  public XlScaleType ScaleType { get; set; }
  /// <summary>
  /// Gets or sets the `TickLabelPosition` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabelposition?view=office-pia
  /// </remarks>
  public XlTickLabelPosition TickLabelPosition { get; set; }
  /// <summary>
  /// Gets the `TickLabels` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabels?view=office-pia
  /// </remarks>
  public IMsoTickLabels TickLabels { get; }
  /// <summary>
  /// Gets or sets the `TickLabelSpacing` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.ticklabelspacing?view=office-pia
  /// </remarks>
  public int TickLabelSpacing { get; set; }
  /// <summary>
  /// Gets or sets the `TickMarkSpacing` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.tickmarkspacing?view=office-pia
  /// </remarks>
  public int TickMarkSpacing { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.type?view=office-pia
  /// </remarks>
  public XlAxisType Type { get; set; }
  /// <summary>
  /// Gets or sets the `BaseUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.baseunit?view=office-pia
  /// </remarks>
  public XlTimeUnit BaseUnit { get; set; }
  /// <summary>
  /// Gets or sets the `BaseUnitIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.baseunitisauto?view=office-pia
  /// </remarks>
  public bool BaseUnitIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `MajorUnitScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.majorunitscale?view=office-pia
  /// </remarks>
  public XlTimeUnit MajorUnitScale { get; set; }
  /// <summary>
  /// Gets or sets the `MinorUnitScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.minorunitscale?view=office-pia
  /// </remarks>
  public XlTimeUnit MinorUnitScale { get; set; }
  /// <summary>
  /// Gets or sets the `CategoryType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.categorytype?view=office-pia
  /// </remarks>
  public XlCategoryType CategoryType { get; set; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.left?view=office-pia
  /// </remarks>
  public double Left { get; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.top?view=office-pia
  /// </remarks>
  public double Top { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.width?view=office-pia
  /// </remarks>
  public double Width { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.height?view=office-pia
  /// </remarks>
  public double Height { get; }
  /// <summary>
  /// Gets or sets the `DisplayUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.displayunit?view=office-pia
  /// </remarks>
  public XlDisplayUnit DisplayUnit { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayUnitCustom` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.displayunitcustom?view=office-pia
  /// </remarks>
  public double DisplayUnitCustom { get; set; }
  /// <summary>
  /// Gets or sets the `HasDisplayUnitLabel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.hasdisplayunitlabel?view=office-pia
  /// </remarks>
  public bool HasDisplayUnitLabel { get; set; }
  /// <summary>
  /// Gets the `DisplayUnitLabel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.displayunitlabel?view=office-pia
  /// </remarks>
  public IMsoDisplayUnitLabel DisplayUnitLabel { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
