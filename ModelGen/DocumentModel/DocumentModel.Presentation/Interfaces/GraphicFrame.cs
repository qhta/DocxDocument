namespace DocumentModel.Presentation;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface GraphicFrame // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Properties for a Graphic Frame.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// 2D Transform for Graphic Frame.
  /// </summary>
  public Transform? Transform { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic { get ; set; }
  
  /// <summary>
  /// Extension List with Modification Flag.
  /// </summary>
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
