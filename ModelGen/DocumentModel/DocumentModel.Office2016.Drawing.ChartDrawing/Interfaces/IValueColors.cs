namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface IValueColors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlSolidColorFillPropertiesElement? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlSolidColorFillPropertiesElement? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlSolidColorFillPropertiesElement? MaxColorSolidColorFillProperties { get ; set; }
  
}
