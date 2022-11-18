namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Axis Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAxisTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAxisUnits))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ICategoryAxisScaling))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMajorGridlinesGridlines))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMinorGridlinesGridlines))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumberFormat))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ITickLabels))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMajorTickMarksTickMarks))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMinorTickMarksTickMarks))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IValueAxisScaling))]
public interface IAxis // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Hidden { get ; set; }
  
}
