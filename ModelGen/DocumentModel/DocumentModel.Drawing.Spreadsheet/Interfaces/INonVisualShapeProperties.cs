namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
public interface INonVisualShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Connection Non-Visual Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
