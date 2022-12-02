namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface IValueColors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawing.IMinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawing.IMidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawing.IMaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
