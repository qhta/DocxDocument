namespace DocumentModel.Office2010.Excel.Drawing;

/// <summary>
/// Defines the ExcelNonVisualContentPartShapeProperties Class.
/// </summary>
public interface IExcelNonVisualContentPartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
