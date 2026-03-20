
namespace DocumentModel.Interop.Core;

public partial interface IMsoChart
{
  public void UnProtect(object Password);
  public void Protect(object Password, object DrawingObjects, object Contents, object Scenarios, object UserInterfaceOnly);
  public object SeriesCollection(object Index);
  public void _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
  public void ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
  public void ApplyCustomType(XlChartType ChartType, object TypeName);
  public void GetChartElement(int x, int y, ref int ElementID, ref int Arg1, ref int Arg2);
  public void SetSourceData(string Source, object PlotBy);
  public object Axes(object Type, XlAxisGroup AxisGroup);
  public void AutoFormat(int rGallery, object varFormat);
  public void SetBackgroundPicture(string bstr);
  public void ChartWizard
  (object varSource, object varGallery, object varFormat, object varPlotBy, object varCategoryLabels,
    object varSeriesLabels, object varHasLegend, object varTitle, object varCategoryTitle, object varValueTitle,
    object varExtraTitle);
  public void CopyPicture(int Appearance, int Format, int Size);
  public object Evaluate(object varName, int LocaleID, out int ObjType);
  public object _Evaluate(object varName, int LocaleID);
  public void Paste(object varType);
  public bool Export(string bstr, object varFilterName, object varInteractive);
  public void SetDefaultChart(object varName);
  public void ApplyChartTemplate(string bstrFileName);
  public void SaveChartTemplate(string bstrFileName);
  public void ClearToMatchStyle();
  public void RefreshPivotTable();
  public void ApplyLayout(int Layout, object varChartType);
  public void Refresh();
  public void SetElement(MsoChartElementType RHS);
  public object AreaGroups(object Index);
  public object BarGroups(object Index);
  public object ColumnGroups(object Index);
  public object LineGroups(object Index);
  public object PieGroups(object Index);
  public object DoughnutGroups(object Index);
  public object RadarGroups(object Index);
  public object XYGroups(object Index);
  public object Delete();
  public object Copy();
  public object Select(object Replace);
  public object FullSeriesCollection(object Index);
  public void DeleteHiddenContent();
  public void ClearToMatchColorStyle();
}
