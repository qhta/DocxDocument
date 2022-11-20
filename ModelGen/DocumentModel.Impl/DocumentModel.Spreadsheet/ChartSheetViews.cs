namespace DocumentModel.Spreadsheet;

/// <summary>
/// Chart Sheet Views.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IChartSheetView))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class ChartSheetViews: IChartSheetViews
{
}
