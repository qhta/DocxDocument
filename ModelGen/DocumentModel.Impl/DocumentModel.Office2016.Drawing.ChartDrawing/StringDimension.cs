namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INfFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IStringLevel))]
public class StringDimension: IStringDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public StringDimensionType? Type
  {
    get;
    set;
  }
  
}
