namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Stock Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDropLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHighLowLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILineChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStockChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IUpDownBars))]
public interface IStockChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
