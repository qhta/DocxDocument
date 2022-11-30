namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface IValueColors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
