namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface IDataLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Idx { get ; set; }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.DataLabelPos? Pos { get ; set; }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.INumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IDataLabelVisibilities? DataLabelVisibilities { get ; set; }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public System.String? SeparatorXsdstring { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
