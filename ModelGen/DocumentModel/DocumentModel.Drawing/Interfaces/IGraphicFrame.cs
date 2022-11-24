namespace DocumentModel.Drawing;

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
  /// Graphic.
  /// </summary>
  public IGraphic? Graphic { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
