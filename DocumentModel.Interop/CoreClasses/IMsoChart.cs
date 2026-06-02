
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart?view=office-pia"/>
public partial class MsoChart
{
  /// <summary>
  /// Gets or sets the `HasTitle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hastitle?view=office-pia"/>
  public bool HasTitle { get; set; }
  /// <summary>
  /// Gets the `ChartTitle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.charttitle?view=office-pia"/>
  public IMsoChartTitle ChartTitle { get; }
  /// <summary>
  /// Gets or sets the `DepthPercent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.depthpercent?view=office-pia"/>
  public int DepthPercent { get; set; }
  /// <summary>
  /// Gets or sets the `Elevation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.elevation?view=office-pia"/>
  public int Elevation { get; set; }
  /// <summary>
  /// Gets or sets the `GapDepth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.gapdepth?view=office-pia"/>
  public int GapDepth { get; set; }
  /// <summary>
  /// Gets or sets the `HeightPercent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.heightpercent?view=office-pia"/>
  public int HeightPercent { get; set; }
  /// <summary>
  /// Gets or sets the `Perspective` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.perspective?view=office-pia"/>
  public int Perspective { get; set; }
  /// <summary>
  /// Gets or sets the `RightAngleAxes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.rightangleaxes?view=office-pia"/>
  public object RightAngleAxes { get; set; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.rotation?view=office-pia"/>
  public object Rotation { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayBlanksAs` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.displayblanksas?view=office-pia"/>
  public DisplayBlanksAs DisplayBlanksAs { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectData` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectdata?view=office-pia"/>
  public bool ProtectData { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectFormatting` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectformatting?view=office-pia"/>
  public bool ProtectFormatting { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectGoalSeek` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectgoalseek?view=office-pia"/>
  public bool ProtectGoalSeek { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectSelection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectselection?view=office-pia"/>
  public bool ProtectSelection { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectChartObjects` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectchartobjects?view=office-pia"/>
  public bool ProtectChartObjects { get; set; }
  /// <summary>
  /// Gets the `ChartGroups` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartgroups?view=office-pia"/>
  public object ChartGroups { get; }
  /// <summary>
  /// Gets or sets the `SubType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.subtype?view=office-pia"/>
  public int SubType { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.type?view=office-pia"/>
  public int Type { get; set; }
  /// <summary>
  /// Gets the `Corners` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.corners?view=office-pia"/>
  public IMsoCorners Corners { get; }
  /// <summary>
  /// Gets or sets the `ChartType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.charttype?view=office-pia"/>
  public ChartType ChartType { get; set; }
  /// <summary>
  /// Gets or sets the `HasDataTable` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hasdatatable?view=office-pia"/>
  public bool HasDataTable { get; set; }
  /// <summary>
  /// Gets or sets the `PlotBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotby?view=office-pia"/>
  public RowCol PlotBy { get; set; }
  /// <summary>
  /// Gets or sets the `HasLegend` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.haslegend?view=office-pia"/>
  public bool HasLegend { get; set; }
  /// <summary>
  /// Gets the `Legend` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.legend?view=office-pia"/>
  public IMsoLegend Legend { get; }
  /// <summary>
  /// Gets or sets the `HasAxis` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hasaxis?view=office-pia"/>
  public object HasAxis { get; set; }
  /// <summary>
  /// Gets the `Walls` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.walls?view=office-pia"/>
  public IMsoWalls Walls { get; }
  /// <summary>
  /// Gets the `Floor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.floor?view=office-pia"/>
  public IMsoFloor Floor { get; }
  /// <summary>
  /// Gets the `PlotArea` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotarea?view=office-pia"/>
  public IMsoPlotArea PlotArea { get; }
  /// <summary>
  /// Gets or sets the `PlotVisibleOnly` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotvisibleonly?view=office-pia"/>
  public bool PlotVisibleOnly { get; set; }
  /// <summary>
  /// Gets the `ChartArea` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartarea?view=office-pia"/>
  public IMsoChartArea ChartArea { get; }
  /// <summary>
  /// Gets or sets the `AutoScaling` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.autoscaling?view=office-pia"/>
  public bool AutoScaling { get; set; }
  /// <summary>
  /// Gets the `DataTable` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.datatable?view=office-pia"/>
  public IMsoDataTable DataTable { get; }
  /// <summary>
  /// Gets or sets the `BarShape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.barshape?view=office-pia"/>
  public BarShape BarShape { get; set; }
  /// <summary>
  /// Gets the `SideWall` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.sidewall?view=office-pia"/>
  public IMsoWalls SideWall { get; }
  /// <summary>
  /// Gets the `BackWall` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.backwall?view=office-pia"/>
  public IMsoWalls BackWall { get; }
  /// <summary>
  /// Gets or sets the `ChartStyle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartstyle?view=office-pia"/>
  public object ChartStyle { get; set; }
  /// <summary>
  /// Gets the `PivotLayout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.pivotlayout?view=office-pia"/>
  public object PivotLayout { get; }
  /// <summary>
  /// Gets or sets the `HasPivotFields` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.haspivotfields?view=office-pia"/>
  public bool HasPivotFields { get; set; }
  /// <summary>
  /// Gets or sets the `ShowDataLabelsOverMaximum` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showdatalabelsovermaximum?view=office-pia"/>
  public bool ShowDataLabelsOverMaximum { get; set; }
  /// <summary>
  /// Gets the `Selection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.selection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the `ChartData` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartdata?view=office-pia"/>
  public IMsoChartData ChartData { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.format?view=office-pia"/>
  public MsoChartFormat Format { get; }
  /// <summary>
  /// Gets the `Shapes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.shapes?view=office-pia"/>
  public Shapes Shapes { get; }
  /// <summary>
  /// Gets the `Area3DGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.area3dgroup?view=office-pia"/>
  public MsoChartGroup? Area3DGroup { get; }
  /// <summary>
  /// Gets the `Bar3DGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.bar3dgroup?view=office-pia"/>
  public MsoChartGroup? Bar3DGroup { get; }
  /// <summary>
  /// Gets the `Column3DGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.column3dgroup?view=office-pia"/>
  public MsoChartGroup? Column3DGroup { get; }
  /// <summary>
  /// Gets the `Line3DGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.line3dgroup?view=office-pia"/>
  public MsoChartGroup? Line3DGroup { get; }
  /// <summary>
  /// Gets the `Pie3DGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.pie3dgroup?view=office-pia"/>
  public MsoChartGroup? Pie3DGroup { get; }
  /// <summary>
  /// Gets the `SurfaceGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.surfacegroup?view=office-pia"/>
  public MsoChartGroup? SurfaceGroup { get; }
  /// <summary>
  /// Gets or sets the `ShowReportFilterFieldButtons` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showreportfilterfieldbuttons?view=office-pia"/>
  public bool ShowReportFilterFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendFieldButtons` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showlegendfieldbuttons?view=office-pia"/>
  public bool ShowLegendFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowAxisFieldButtons` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showaxisfieldbuttons?view=office-pia"/>
  public bool ShowAxisFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValueFieldButtons` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showvaluefieldbuttons?view=office-pia"/>
  public bool ShowValueFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowAllFieldButtons` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showallfieldbuttons?view=office-pia"/>
  public bool ShowAllFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectChartSheetFormatting` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectchartsheetformatting?view=office-pia"/>
  public bool ProtectChartSheetFormatting { get; set; }
  /// <summary>
  /// Gets or sets the `CategoryLabelLevel` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.categorylabellevel?view=office-pia"/>
  public CategoryLabelLevel CategoryLabelLevel { get; set; }
  /// <summary>
  /// Gets or sets the `SeriesNameLevel` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.seriesnamelevel?view=office-pia"/>
  public SeriesNameLevel SeriesNameLevel { get; set; }
  /// <summary>
  /// Gets the `HasHiddenContent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hashiddencontent?view=office-pia"/>
  public bool HasHiddenContent { get; set; }
  /// <summary>
  /// Gets or sets the `ChartColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartcolor?view=office-pia"/>
  public object? ChartColor { get; set; }


  #region methods

/// <summary>
  /// Invokes `UnProtect`.
  /// </summary>
  /// <param name="Password">The `Password` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.unprotect?view=office-pia"/>
  public void UnProtect(object Password) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Protect`.
  /// </summary>
  /// <param name="Password">The `Password` parameter.</param>
  /// <param name="DrawingObjects">The `DrawingObjects` parameter.</param>
  /// <param name="Contents">The `Contents` parameter.</param>
  /// <param name="Scenarios">The `Scenarios` parameter.</param>
  /// <param name="UserInterfaceOnly">The `UserInterfaceOnly` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protect?view=office-pia"/>
  public void Protect(object Password, object DrawingObjects, object Contents, object Scenarios, object UserInterfaceOnly) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SeriesCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.seriescollection?view=office-pia"/>
  public object SeriesCollection(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `_ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="IMsoLegendKey">The `IMsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart._applydatalabels?view=office-pia"/>
  public void _ApplyDataLabels
  (DataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="IMsoLegendKey">The `IMsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <param name="ShowSeriesName">The `ShowSeriesName` parameter.</param>
  /// <param name="ShowCategoryName">The `ShowCategoryName` parameter.</param>
  /// <param name="ShowValue">The `ShowValue` parameter.</param>
  /// <param name="ShowPercentage">The `ShowPercentage` parameter.</param>
  /// <param name="ShowBubbleSize">The `ShowBubbleSize` parameter.</param>
  /// <param name="Separator">The `Separator` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applydatalabels?view=office-pia"/>
  public void ApplyDataLabels
  (DataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ApplyCustomType`.
  /// </summary>
  /// <param name="ChartType">The `ChartType` parameter.</param>
  /// <param name="TypeName">The `TypeName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applycustomtype?view=office-pia"/>
  public void ApplyCustomType(ChartType ChartType, object TypeName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetChartElement`.
  /// </summary>
  /// <param name="x">The `x` parameter.</param>
  /// <param name="y">The `y` parameter.</param>
  /// <param name="ElementID">The `ElementID` parameter.</param>
  /// <param name="Arg1">The `Arg1` parameter.</param>
  /// <param name="Arg2">The `Arg2` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.getchartelement?view=office-pia"/>
  public void GetChartElement(int x, int y, ref int ElementID, ref int Arg1, ref int Arg2) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetSourceData`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="PlotBy">The `PlotBy` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setsourcedata?view=office-pia"/>
  public void SetSourceData(string Source, object PlotBy) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Axes`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="AxisGroup">The `AxisGroup` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.axes?view=office-pia"/>
  public object Axes(object Type, AxisGroup AxisGroup) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AutoFormat`.
  /// </summary>
  /// <param name="rGallery">The `rGallery` parameter.</param>
  /// <param name="varFormat">The `varFormat` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.autoformat?view=office-pia"/>
  public void AutoFormat(int rGallery, object varFormat) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetBackgroundPicture`.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setbackgroundpicture?view=office-pia"/>
  public void SetBackgroundPicture(string bstr) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ChartWizard`.
  /// </summary>
  /// <param name="varSource">The `varSource` parameter.</param>
  /// <param name="varGallery">The `varGallery` parameter.</param>
  /// <param name="varFormat">The `varFormat` parameter.</param>
  /// <param name="varPlotBy">The `varPlotBy` parameter.</param>
  /// <param name="varCategoryLabels">The `varCategoryLabels` parameter.</param>
  /// <param name="varSeriesLabels">The `varSeriesLabels` parameter.</param>
  /// <param name="varHasLegend">The `varHasLegend` parameter.</param>
  /// <param name="varTitle">The `varTitle` parameter.</param>
  /// <param name="varCategoryTitle">The `varCategoryTitle` parameter.</param>
  /// <param name="varValueTitle">The `varValueTitle` parameter.</param>
  /// <param name="varExtraTitle">The `varExtraTitle` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartwizard?view=office-pia"/>
  public void ChartWizard
  (object varSource, object varGallery, object varFormat, object varPlotBy, object varCategoryLabels,
    object varSeriesLabels, object varHasLegend, object varTitle, object varCategoryTitle, object varValueTitle,
    object varExtraTitle) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CopyPicture`.
  /// </summary>
  /// <param name="Appearance">The `Appearance` parameter.</param>
  /// <param name="Format">The `Format` parameter.</param>
  /// <param name="Size">The `Size` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.copypicture?view=office-pia"/>
  public void CopyPicture(int Appearance, int Format, int Size) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Evaluate`.
  /// </summary>
  /// <param name="varName">The `varName` parameter.</param>
  /// <param name="LocaleID">The `LocaleID` parameter.</param>
  /// <param name="ObjType">The `ObjType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.evaluate?view=office-pia"/>
  public object Evaluate(object varName, int LocaleID, out int ObjType) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `_Evaluate`.
  /// </summary>
  /// <param name="varName">The `varName` parameter.</param>
  /// <param name="LocaleID">The `LocaleID` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart._evaluate?view=office-pia"/>
  public object _Evaluate(object varName, int LocaleID) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <param name="varType">The `varType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.paste?view=office-pia"/>
  public void Paste(object varType) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Export`.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <param name="varFilterName">The `varFilterName` parameter.</param>
  /// <param name="varInteractive">The `varInteractive` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.export?view=office-pia"/>
  public bool Export(string bstr, object varFilterName, object varInteractive) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetDefaultChart`.
  /// </summary>
  /// <param name="varName">The `varName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setdefaultchart?view=office-pia"/>
  public void SetDefaultChart(object varName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ApplyChartTemplate`.
  /// </summary>
  /// <param name="bstrFileName">The `bstrFileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applycharttemplate?view=office-pia"/>
  public void ApplyChartTemplate(string bstrFileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SaveChartTemplate`.
  /// </summary>
  /// <param name="bstrFileName">The `bstrFileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.savecharttemplate?view=office-pia"/>
  public void SaveChartTemplate(string bstrFileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ClearToMatchStyle`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.cleartomatchstyle?view=office-pia"/>
  public void ClearToMatchStyle() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RefreshPivotTable`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.refreshpivottable?view=office-pia"/>
  public void RefreshPivotTable() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ApplyLayout`.
  /// </summary>
  /// <param name="Layout">The `Layout` parameter.</param>
  /// <param name="varChartType">The `varChartType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applylayout?view=office-pia"/>
  public void ApplyLayout(int Layout, object varChartType) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Refresh`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.refresh?view=office-pia"/>
  public void Refresh() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetElement`.
  /// </summary>
  /// <param name="RHS">The `RHS` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setelement?view=office-pia"/>
  public void SetElement(ChartElementType RHS) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AreaGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.areagroups?view=office-pia"/>
  public object AreaGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `BarGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.bargroups?view=office-pia"/>
  public object BarGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ColumnGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.columngroups?view=office-pia"/>
  public object ColumnGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `LineGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.linegroups?view=office-pia"/>
  public object LineGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PieGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.piegroups?view=office-pia"/>
  public object PieGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DoughnutGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.doughnutgroups?view=office-pia"/>
  public object DoughnutGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RadarGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.radargroups?view=office-pia"/>
  public object RadarGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `XYGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.xygroups?view=office-pia"/>
  public object XYGroups(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.delete?view=office-pia"/>
  public object Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.copy?view=office-pia"/>
  public object Copy() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.select?view=office-pia"/>
  public object Select(object Replace) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `FullSeriesCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.fullseriescollection?view=office-pia"/>
  public object FullSeriesCollection(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DeleteHiddenContent`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.deletehiddencontent?view=office-pia"/>
  public void DeleteHiddenContent() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ClearToMatchColorStyle`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.cleartomatchcolorstyle?view=office-pia"/>
  public void ClearToMatchColorStyle() { throw new NotImplementedException(); }

  #endregion methods
}

