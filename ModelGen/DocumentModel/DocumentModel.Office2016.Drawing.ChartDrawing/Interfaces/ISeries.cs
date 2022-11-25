namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Series Class.
/// </summary>
public interface ISeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.SeriesLayout? LayoutId { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? OwnerIdx { get ; set; }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? FormatIdx { get ; set; }
  
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
  public DocumentModel.Office2016.Drawing.ChartDrawing.IValueColors? ValueColors { get ; set; }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IValueColorPositions? ValueColorPositions { get ; set; }
  
}
