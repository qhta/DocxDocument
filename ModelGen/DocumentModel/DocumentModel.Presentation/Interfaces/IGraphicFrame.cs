namespace DocumentModel.Presentation;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface IGraphicFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Graphic Frame.
  /// </summary>
  public INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// 2D Transform for Graphic Frame.
  /// </summary>
  public ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
  /// <summary>
  /// Extension List with Modification Flag.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
