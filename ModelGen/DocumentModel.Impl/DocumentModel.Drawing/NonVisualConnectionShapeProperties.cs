namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualConnectorShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualDrawingProperties))]
public class NonVisualConnectionShapeProperties: INonVisualConnectionShapeProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get;
    set;
  }
  
}
