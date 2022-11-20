namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the MinorTickMarksTickMarks Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
public class MinorTickMarksTickMarks: IMinorTickMarksTickMarks
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public TickMarksType? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
