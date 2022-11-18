namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Properties for a Group Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualGroupShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties))]
public interface INonVisualGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }
  
}
