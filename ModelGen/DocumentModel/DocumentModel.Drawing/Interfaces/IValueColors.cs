namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface IValueColors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public IMinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public IMidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public IMaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
