namespace DocumentModel.Presentation;

/// <summary>
/// Picture Fill.
/// </summary>
public interface IBlipFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  public UInt32? Dpi { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip { get ; set; }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRelativeRectangleType? SourceRectangle { get ; set; }
  
  public DocumentModel.Drawing.ITile? Tile { get ; set; }
  
  public DocumentModel.Drawing.IStretch? Stretch { get ; set; }
  
}
