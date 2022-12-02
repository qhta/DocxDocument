namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
public interface INonVisualShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Connection Non-Visual Shape Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
