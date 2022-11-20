namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Series Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IDataId))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ISeriesLayoutProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IText))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IValueColorPositions))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IValueColors))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAxisId))]
public interface ISeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public SeriesLayout? LayoutId { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Hidden { get ; set; }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? OwnerIdx { get ; set; }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? UniqueId { get ; set; }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? FormatIdx { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IText? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public IValueColors? ValueColors { get ; set; }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public IValueColorPositions? ValueColorPositions { get ; set; }
  
}
