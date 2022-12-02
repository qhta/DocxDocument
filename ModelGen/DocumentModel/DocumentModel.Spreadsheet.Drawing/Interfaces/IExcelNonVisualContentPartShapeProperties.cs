namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Defines the ExcelNonVisualContentPartShapeProperties Class.
/// </summary>
public interface IExcelNonVisualContentPartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
