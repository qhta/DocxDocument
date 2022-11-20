namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IDataLabelVisibilities))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumberFormat))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ISeparatorXsdstring))]
public interface IDataLabel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Idx { get ; set; }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DataLabelPos? Pos { get ; set; }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public INumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public IDataLabelVisibilities? DataLabelVisibilities { get ; set; }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public ISeparatorXsdstring? SeparatorXsdstring { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
