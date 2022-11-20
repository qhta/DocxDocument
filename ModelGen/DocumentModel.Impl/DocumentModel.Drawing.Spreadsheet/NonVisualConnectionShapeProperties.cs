namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualConnectorShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties))]
public class NonVisualConnectionShapeProperties: INonVisualConnectionShapeProperties
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get;
    set;
  }
  
}
