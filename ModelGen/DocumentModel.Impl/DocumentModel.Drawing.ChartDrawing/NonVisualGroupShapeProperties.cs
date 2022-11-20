namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualGroupShapeDrawingProperties))]
public class NonVisualGroupShapeProperties: INonVisualGroupShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get;
    set;
  }
  
}
