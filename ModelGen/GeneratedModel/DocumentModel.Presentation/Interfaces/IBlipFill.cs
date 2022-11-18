namespace DocumentModel.Presentation;

/// <summary>
/// Picture Fill.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlip))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISourceRectangle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IStretch))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITile))]
public interface IBlipFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  public uint? Dpi { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public bool? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip { get ; set; }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public ISourceRectangle? SourceRectangle { get ; set; }
  
}
