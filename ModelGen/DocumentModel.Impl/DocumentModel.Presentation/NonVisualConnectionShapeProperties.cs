namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualConnectorShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IApplicationNonVisualDrawingProperties))]
public class NonVisualConnectionShapeProperties: INonVisualConnectionShapeProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Connector Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get;
    set;
  }
  
}
