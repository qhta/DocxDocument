namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface IGraphicFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public IGraphic? Graphic { get ; set; }
  
}
