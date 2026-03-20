
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart?view=office-pia
/// </remarks>
public partial interface IMsoChart
{
  /// <summary>
  /// Invokes `UnProtect`.
  /// </summary>
  /// <param name="Password">The `Password` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.unprotect?view=office-pia
  /// </remarks>
  public void UnProtect(object Password);
  /// <summary>
  /// Invokes `Protect`.
  /// </summary>
  /// <param name="Password">The `Password` parameter.</param>
  /// <param name="DrawingObjects">The `DrawingObjects` parameter.</param>
  /// <param name="Contents">The `Contents` parameter.</param>
  /// <param name="Scenarios">The `Scenarios` parameter.</param>
  /// <param name="UserInterfaceOnly">The `UserInterfaceOnly` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protect?view=office-pia
  /// </remarks>
  public void Protect(object Password, object DrawingObjects, object Contents, object Scenarios, object UserInterfaceOnly);
  /// <summary>
  /// Invokes `SeriesCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.seriescollection?view=office-pia
  /// </remarks>
  public object SeriesCollection(object Index);
  /// <summary>
  /// Invokes `_ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="IMsoLegendKey">The `IMsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart._applydatalabels?view=office-pia
  /// </remarks>
  public void _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
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
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applydatalabels?view=office-pia
  /// </remarks>
  public void ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
  /// <summary>
  /// Invokes `ApplyCustomType`.
  /// </summary>
  /// <param name="ChartType">The `ChartType` parameter.</param>
  /// <param name="TypeName">The `TypeName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applycustomtype?view=office-pia
  /// </remarks>
  public void ApplyCustomType(XlChartType ChartType, object TypeName);
  /// <summary>
  /// Invokes `GetChartElement`.
  /// </summary>
  /// <param name="x">The `x` parameter.</param>
  /// <param name="y">The `y` parameter.</param>
  /// <param name="ElementID">The `ElementID` parameter.</param>
  /// <param name="Arg1">The `Arg1` parameter.</param>
  /// <param name="Arg2">The `Arg2` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.getchartelement?view=office-pia
  /// </remarks>
  public void GetChartElement(int x, int y, ref int ElementID, ref int Arg1, ref int Arg2);
  /// <summary>
  /// Invokes `SetSourceData`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="PlotBy">The `PlotBy` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setsourcedata?view=office-pia
  /// </remarks>
  public void SetSourceData(string Source, object PlotBy);
  /// <summary>
  /// Invokes `Axes`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="AxisGroup">The `AxisGroup` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.axes?view=office-pia
  /// </remarks>
  public object Axes(object Type, XlAxisGroup AxisGroup);
  /// <summary>
  /// Invokes `AutoFormat`.
  /// </summary>
  /// <param name="rGallery">The `rGallery` parameter.</param>
  /// <param name="varFormat">The `varFormat` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.autoformat?view=office-pia
  /// </remarks>
  public void AutoFormat(int rGallery, object varFormat);
  /// <summary>
  /// Invokes `SetBackgroundPicture`.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setbackgroundpicture?view=office-pia
  /// </remarks>
  public void SetBackgroundPicture(string bstr);
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
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartwizard?view=office-pia
  /// </remarks>
  public void ChartWizard
  (object varSource, object varGallery, object varFormat, object varPlotBy, object varCategoryLabels,
    object varSeriesLabels, object varHasLegend, object varTitle, object varCategoryTitle, object varValueTitle,
    object varExtraTitle);
  /// <summary>
  /// Invokes `CopyPicture`.
  /// </summary>
  /// <param name="Appearance">The `Appearance` parameter.</param>
  /// <param name="Format">The `Format` parameter.</param>
  /// <param name="Size">The `Size` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.copypicture?view=office-pia
  /// </remarks>
  public void CopyPicture(int Appearance, int Format, int Size);
  /// <summary>
  /// Invokes `Evaluate`.
  /// </summary>
  /// <param name="varName">The `varName` parameter.</param>
  /// <param name="LocaleID">The `LocaleID` parameter.</param>
  /// <param name="ObjType">The `ObjType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.evaluate?view=office-pia
  /// </remarks>
  public object Evaluate(object varName, int LocaleID, out int ObjType);
  /// <summary>
  /// Invokes `_Evaluate`.
  /// </summary>
  /// <param name="varName">The `varName` parameter.</param>
  /// <param name="LocaleID">The `LocaleID` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart._evaluate?view=office-pia
  /// </remarks>
  public object _Evaluate(object varName, int LocaleID);
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <param name="varType">The `varType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.paste?view=office-pia
  /// </remarks>
  public void Paste(object varType);
  /// <summary>
  /// Invokes `Export`.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <param name="varFilterName">The `varFilterName` parameter.</param>
  /// <param name="varInteractive">The `varInteractive` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.export?view=office-pia
  /// </remarks>
  public bool Export(string bstr, object varFilterName, object varInteractive);
  /// <summary>
  /// Invokes `SetDefaultChart`.
  /// </summary>
  /// <param name="varName">The `varName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setdefaultchart?view=office-pia
  /// </remarks>
  public void SetDefaultChart(object varName);
  /// <summary>
  /// Invokes `ApplyChartTemplate`.
  /// </summary>
  /// <param name="bstrFileName">The `bstrFileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applycharttemplate?view=office-pia
  /// </remarks>
  public void ApplyChartTemplate(string bstrFileName);
  /// <summary>
  /// Invokes `SaveChartTemplate`.
  /// </summary>
  /// <param name="bstrFileName">The `bstrFileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.savecharttemplate?view=office-pia
  /// </remarks>
  public void SaveChartTemplate(string bstrFileName);
  /// <summary>
  /// Invokes `ClearToMatchStyle`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.cleartomatchstyle?view=office-pia
  /// </remarks>
  public void ClearToMatchStyle();
  /// <summary>
  /// Invokes `RefreshPivotTable`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.refreshpivottable?view=office-pia
  /// </remarks>
  public void RefreshPivotTable();
  /// <summary>
  /// Invokes `ApplyLayout`.
  /// </summary>
  /// <param name="Layout">The `Layout` parameter.</param>
  /// <param name="varChartType">The `varChartType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.applylayout?view=office-pia
  /// </remarks>
  public void ApplyLayout(int Layout, object varChartType);
  /// <summary>
  /// Invokes `Refresh`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.refresh?view=office-pia
  /// </remarks>
  public void Refresh();
  /// <summary>
  /// Invokes `SetElement`.
  /// </summary>
  /// <param name="RHS">The `RHS` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.setelement?view=office-pia
  /// </remarks>
  public void SetElement(MsoChartElementType RHS);
  /// <summary>
  /// Invokes `AreaGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.areagroups?view=office-pia
  /// </remarks>
  public object AreaGroups(object Index);
  /// <summary>
  /// Invokes `BarGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.bargroups?view=office-pia
  /// </remarks>
  public object BarGroups(object Index);
  /// <summary>
  /// Invokes `ColumnGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.columngroups?view=office-pia
  /// </remarks>
  public object ColumnGroups(object Index);
  /// <summary>
  /// Invokes `LineGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.linegroups?view=office-pia
  /// </remarks>
  public object LineGroups(object Index);
  /// <summary>
  /// Invokes `PieGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.piegroups?view=office-pia
  /// </remarks>
  public object PieGroups(object Index);
  /// <summary>
  /// Invokes `DoughnutGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.doughnutgroups?view=office-pia
  /// </remarks>
  public object DoughnutGroups(object Index);
  /// <summary>
  /// Invokes `RadarGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.radargroups?view=office-pia
  /// </remarks>
  public object RadarGroups(object Index);
  /// <summary>
  /// Invokes `XYGroups`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.xygroups?view=office-pia
  /// </remarks>
  public object XYGroups(object Index);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.copy?view=office-pia
  /// </remarks>
  public object Copy();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.select?view=office-pia
  /// </remarks>
  public object Select(object Replace);
  /// <summary>
  /// Invokes `FullSeriesCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.fullseriescollection?view=office-pia
  /// </remarks>
  public object FullSeriesCollection(object Index);
  /// <summary>
  /// Invokes `DeleteHiddenContent`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.deletehiddencontent?view=office-pia
  /// </remarks>
  public void DeleteHiddenContent();
  /// <summary>
  /// Invokes `ClearToMatchColorStyle`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.cleartomatchcolorstyle?view=office-pia
  /// </remarks>
  public void ClearToMatchColorStyle();
}
