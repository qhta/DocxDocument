namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.INonVisualInkContentPartProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IApplicationNonVisualDrawingProperties))]
public class NonVisualContentPartProperties: INonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get;
    set;
  }
  
}
