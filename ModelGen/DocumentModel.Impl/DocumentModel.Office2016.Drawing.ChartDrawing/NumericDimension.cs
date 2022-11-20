namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INfFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumericLevel))]
public class NumericDimension: INumericDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public NumericDimensionType? Type
  {
    get;
    set;
  }
  
}
