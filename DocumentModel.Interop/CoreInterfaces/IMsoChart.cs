
namespace DocumentModel.Interop.Core;

public interface IMsoChart
{
  public bool HasTitle { get; set; }
  public IMsoChartTitle ChartTitle { get; }
  public int DepthPercent { get; set; }
  public int Elevation { get; set; }
  public int GapDepth { get; set; }
  public int HeightPercent { get; set; }
  public int Perspective { get; set; }
  public object RightAngleAxes { get; set; }
  public object Rotation { get; set; }
  public XlDisplayBlanksAs DisplayBlanksAs { get; set; }
  public bool ProtectData { get; set; }
  public bool ProtectFormatting { get; set; }
  public bool ProtectGoalSeek { get; set; }
  public bool ProtectSelection { get; set; }
  public bool ProtectChartObjects { get; set; }
  public void UnProtect(object Password);
  public void Protect(object Password, object DrawingObjects, object Contents, object Scenarios, object UserInterfaceOnly);
  public object ChartGroups { get; }
  public object SeriesCollection(object Index);

  public void _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);

  public int SubType { get; set; }
  public int Type { get; set; }
  public IMsoCorners Corners { get; }

  public void ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  public XlChartType ChartType { get; set; }
  public bool HasDataTable { get; set; }
  public void ApplyCustomType(XlChartType ChartType, object TypeName);
  public void GetChartElement(int x, int y, ref int ElementID, ref int Arg1, ref int Arg2);
  public void SetSourceData(string Source, object PlotBy);
  public XlRowCol PlotBy { get; set; }
  public bool HasLegend { get; set; }
  public IMsoLegend Legend { get; }
  public object Axes(object Type, XlAxisGroup AxisGroup);
  public object HasAxis { get; set; }
  public IMsoWalls Walls { get; }
  public IMsoFloor Floor { get; }
  public IMsoPlotArea PlotArea { get; }
  public bool PlotVisibleOnly { get; set; }
  public IMsoChartArea ChartArea { get; }
  public void AutoFormat(int rGallery, object varFormat);
  public bool AutoScaling { get; set; }
  public void SetBackgroundPicture(string bstr);

  public void ChartWizard
  (object varSource, object varGallery, object varFormat, object varPlotBy, object varCategoryLabels,
    object varSeriesLabels, object varHasLegend, object varTitle, object varCategoryTitle, object varValueTitle,
    object varExtraTitle);

  public void CopyPicture(int Appearance, int Format, int Size);
  public IMsoDataTable DataTable { get; }
  public object Evaluate(object varName, int LocaleID, out int ObjType);
  public object _Evaluate(object varName, int LocaleID);
  public void Paste(object varType);
  public XlBarShape BarShape { get; set; }
  public bool Export(string bstr, object varFilterName, object varInteractive);
  public void SetDefaultChart(object varName);
  public void ApplyChartTemplate(string bstrFileName);
  public void SaveChartTemplate(string bstrFileName);
  public IMsoWalls SideWall { get; }
  public IMsoWalls BackWall { get; }
  public object ChartStyle { get; set; }
  public void ClearToMatchStyle();
  public object PivotLayout { get; }
  public bool HasPivotFields { get; set; }
  public void RefreshPivotTable();
  public bool ShowDataLabelsOverMaximum { get; set; }
  public void ApplyLayout(int Layout, object varChartType);
  public object Selection { get; }
  public void Refresh();
  public void SetElement(MsoChartElementType RHS);
  public IMsoChartData ChartData { get; }
  public IMsoChartFormat Format { get; }
  public Shapes Shapes { get; }
  public IMsoChartGroup Area3DGroup { get; }
  public object AreaGroups(object Index);
  public IMsoChartGroup Bar3DGroup { get; }
  public object BarGroups(object Index);
  public IMsoChartGroup Column3DGroup { get; }
  public object ColumnGroups(object Index);
  public IMsoChartGroup Line3DGroup { get; }
  public object LineGroups(object Index);
  public IMsoChartGroup Pie3DGroup { get; }
  public object PieGroups(object Index);
  public object DoughnutGroups(object Index);
  public object RadarGroups(object Index);
  public IMsoChartGroup SurfaceGroup { get; }
  public object XYGroups(object Index);
  public object Delete();
  public object Copy();
  public object Select(object Replace);
  public bool ShowReportFilterFieldButtons { get; set; }
  public bool ShowLegendFieldButtons { get; set; }
  public bool ShowAxisFieldButtons { get; set; }
  public bool ShowValueFieldButtons { get; set; }
  public bool ShowAllFieldButtons { get; set; }
  public bool ProtectChartSheetFormatting { set; }
  public object FullSeriesCollection(object Index);
  public XlCategoryLabelLevel CategoryLabelLevel { get; set; }
  public XlSeriesNameLevel SeriesNameLevel { get; set; }
  public bool HasHiddenContent { get; }
  public void DeleteHiddenContent();
  public object ChartColor { get; set; }
  public void ClearToMatchColorStyle();
}
