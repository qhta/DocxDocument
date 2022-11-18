namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties))]
public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
