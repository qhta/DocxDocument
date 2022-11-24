namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the GraphicFrame Class.
/// </summary>
public interface IGraphicFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGraphicFrameProperties.
  /// </summary>
  public INonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public IGraphic? Graphic { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
