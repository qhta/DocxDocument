namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public interface IGraphicFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public DocumentModel.Drawing.ITransform? Transform { get ; set; }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
}
