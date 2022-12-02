namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
public interface INonVisualConnectionShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }
  
}
