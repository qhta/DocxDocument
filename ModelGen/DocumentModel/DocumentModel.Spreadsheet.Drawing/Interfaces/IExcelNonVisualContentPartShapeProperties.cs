namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Defines the ExcelNonVisualContentPartShapeProperties Class.
/// </summary>
public interface IExcelNonVisualContentPartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
