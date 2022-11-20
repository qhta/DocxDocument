namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Group Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualGroupShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IApplicationNonVisualDrawingProperties))]
public class NonVisualGroupShapeProperties: INonVisualGroupShapeProperties
{
  /// <summary>
  /// Non-visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Properties.
  /// </summary>
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get;
    set;
  }
  
}
