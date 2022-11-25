namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public interface IValueColorPositions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Int32? Count { get ; set; }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlValueColorEndPositionElement? MinValueColorEndPosition { get ; set; }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlValueColorEndPositionElement? MaxValueColorEndPosition { get ; set; }
  
}
