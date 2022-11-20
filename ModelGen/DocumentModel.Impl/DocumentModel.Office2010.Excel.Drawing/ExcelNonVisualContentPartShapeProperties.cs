namespace DocumentModel.Office2010.Excel.Drawing;

/// <summary>
/// Defines the ExcelNonVisualContentPartShapeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.INonVisualInkContentPartProperties))]
public class ExcelNonVisualContentPartShapeProperties: IExcelNonVisualContentPartShapeProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get;
    set;
  }
  
}
