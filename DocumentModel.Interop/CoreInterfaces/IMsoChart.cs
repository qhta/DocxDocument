
namespace DocumentModel.Interop.Core;

public interface IMsoChart
{
  bool HasTitle { get; set; }
  IMsoChartTitle ChartTitle { get; }
  int DepthPercent { get; set; }
  int Elevation { get; set; }
  int GapDepth { get; set; }
  int HeightPercent { get; set; }
  int Perspective { get; set; }
  object RightAngleAxes { get; set; }
  object Rotation { get; set; }
  XlDisplayBlanksAs DisplayBlanksAs { get; set; }
  bool ProtectData { get; set; }
  bool ProtectFormatting { get; set; }
  bool ProtectGoalSeek { get; set; }
  bool ProtectSelection { get; set; }
  bool ProtectChartObjects { get; set; }
  void UnProtect(object Password);
  void Protect(object Password, object DrawingObjects, object Contents, object Scenarios, object UserInterfaceOnly);
  object ChartGroups { get; }
  object SeriesCollection(object Index);

  void _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);

  int SubType { get; set; }
  int Type { get; set; }
  IMsoCorners Corners { get; }

  void ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  XlChartType ChartType { get; set; }
  bool HasDataTable { get; set; }
  void ApplyCustomType(XlChartType ChartType, object TypeName);
  void GetChartElement(int x, int y, ref int ElementID, ref int Arg1, ref int Arg2);
  void SetSourceData(string Source, object PlotBy);
  XlRowCol PlotBy { get; set; }
  bool HasLegend { get; set; }
  IMsoLegend Legend { get; }
  object Axes(object Type, XlAxisGroup AxisGroup);
  object HasAxis { get; set; }
  IMsoWalls Walls { get; }
  IMsoFloor Floor { get; }
  IMsoPlotArea PlotArea { get; }
  bool PlotVisibleOnly { get; set; }
  IMsoChartArea ChartArea { get; }
  void AutoFormat(int rGallery, object varFormat);
  bool AutoScaling { get; set; }
  void SetBackgroundPicture(string bstr);

  void ChartWizard
  (object varSource, object varGallery, object varFormat, object varPlotBy, object varCategoryLabels,
    object varSeriesLabels, object varHasLegend, object varTitle, object varCategoryTitle, object varValueTitle,
    object varExtraTitle);

  void CopyPicture(int Appearance, int Format, int Size);
  IMsoDataTable DataTable { get; }
  object Evaluate(object varName, int LocaleID, out int ObjType);
  object _Evaluate(object varName, int LocaleID);
  void Paste(object varType);
  XlBarShape BarShape { get; set; }
  bool Export(string bstr, object varFilterName, object varInteractive);
  void SetDefaultChart(object varName);
  void ApplyChartTemplate(string bstrFileName);
  void SaveChartTemplate(string bstrFileName);
  IMsoWalls SideWall { get; }
  IMsoWalls BackWall { get; }
  object ChartStyle { get; set; }
  void ClearToMatchStyle();
  object PivotLayout { get; }
  bool HasPivotFields { get; set; }
  void RefreshPivotTable();
  bool ShowDataLabelsOverMaximum { get; set; }
  void ApplyLayout(int Layout, object varChartType);
  object Selection { get; }
  void Refresh();
  void SetElement(MsoChartElementType RHS);
  IMsoChartData ChartData { get; }
  IMsoChartFormat Format { get; }
  Shapes Shapes { get; }
  IMsoChartGroup Area3DGroup { get; }
  object AreaGroups(object Index);
  IMsoChartGroup Bar3DGroup { get; }
  object BarGroups(object Index);
  IMsoChartGroup Column3DGroup { get; }
  object ColumnGroups(object Index);
  IMsoChartGroup Line3DGroup { get; }
  object LineGroups(object Index);
  IMsoChartGroup Pie3DGroup { get; }
  object PieGroups(object Index);
  object DoughnutGroups(object Index);
  object RadarGroups(object Index);
  IMsoChartGroup SurfaceGroup { get; }
  object XYGroups(object Index);
  object Delete();
  object Copy();
  object Select(object Replace);
  bool ShowReportFilterFieldButtons { get; set; }
  bool ShowLegendFieldButtons { get; set; }
  bool ShowAxisFieldButtons { get; set; }
  bool ShowValueFieldButtons { get; set; }
  bool ShowAllFieldButtons { get; set; }
  bool ProtectChartSheetFormatting { set; }
  object FullSeriesCollection(object Index);
  XlCategoryLabelLevel CategoryLabelLevel { get; set; }
  XlSeriesNameLevel SeriesNameLevel { get; set; }
  bool HasHiddenContent { get; }
  void DeleteHiddenContent();
  object ChartColor { get; set; }
  void ClearToMatchColorStyle();
}