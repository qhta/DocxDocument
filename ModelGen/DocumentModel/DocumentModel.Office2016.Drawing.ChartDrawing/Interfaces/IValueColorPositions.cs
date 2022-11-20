namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMinValueColorEndPosition))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMaxValueColorEndPosition))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IValueColorMiddlePosition))]
public interface IValueColorPositions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public int? Count { get ; set; }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public IMinValueColorEndPosition? MinValueColorEndPosition { get ; set; }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public IValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public IMaxValueColorEndPosition? MaxValueColorEndPosition { get ; set; }
  
}
