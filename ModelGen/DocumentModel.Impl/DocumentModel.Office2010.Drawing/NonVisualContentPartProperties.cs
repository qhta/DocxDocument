namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.INonVisualInkContentPartProperties))]
public class NonVisualContentPartProperties: INonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get;
    set;
  }
  
}
