namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the AxisTitle Class.
/// </summary>
public interface IAxisTitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IText? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
