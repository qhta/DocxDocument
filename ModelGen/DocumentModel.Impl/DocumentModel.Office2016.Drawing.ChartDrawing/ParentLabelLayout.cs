namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public class ParentLabelLayout: IParentLabelLayout
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public ParentLabelLayoutVal? ParentLabelLayoutVal
  {
    get;
    set;
  }
  
}
