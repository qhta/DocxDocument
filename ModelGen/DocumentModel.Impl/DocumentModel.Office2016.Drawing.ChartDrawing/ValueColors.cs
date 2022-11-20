namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMinColorSolidColorFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMidColorSolidColorFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IMaxColorSolidColorFillProperties))]
public class ValueColors: IValueColors
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public IMinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public IMidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public IMaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get;
    set;
  }
  
}
