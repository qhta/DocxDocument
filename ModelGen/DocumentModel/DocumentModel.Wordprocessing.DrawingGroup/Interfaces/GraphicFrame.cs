namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the GraphicFrame Class.
/// </summary>
public partial interface GraphicFrame
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// NonVisualGraphicFrameProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.Transform2D? Transform2D { get; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
