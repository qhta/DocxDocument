namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualShapeDrawingProperties))]
public class NonVisualShapeProperties: INonVisualShapeProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get;
    set;
  }
  
}
