namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public interface IEmbeddedObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// dxaOrig
  /// </summary>
  public String? DxaOriginal { get ; set; }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  public String? DyaOriginal { get ; set; }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? AnchorId { get ; set; }
  
  public Collection<DocumentModel.Vml.IGroup>? Groups { get ; set; }
  
  public Collection<DocumentModel.Vml.IImageFile>? ImageFiles { get ; set; }
  
  public Collection<DocumentModel.Vml.ILine>? Lines { get ; set; }
  
  public Collection<DocumentModel.Vml.IOval>? Ovals { get ; set; }
  
  public Collection<DocumentModel.Vml.IPolyLine>? PolyLines { get ; set; }
  
  public Collection<DocumentModel.Vml.IRectangle>? Rectangles { get ; set; }
  
  public Collection<DocumentModel.Vml.IRoundRectangle>? RoundRectangles { get ; set; }
  
  public Collection<DocumentModel.Vml.IShape>? Shapes { get ; set; }
  
  public Collection<DocumentModel.Vml.IShapetype>? Shapetypes { get ; set; }
  
  public Collection<DocumentModel.Vml.IArc>? Arcs { get ; set; }
  
  public Collection<DocumentModel.Vml.ICurve>? Curves { get ; set; }
  
  public Collection<DocumentModel.Vml.IOleObject>? OleObjects { get ; set; }
  
  public IDrawing? Drawing { get ; set; }
  
  public IControl? Control { get ; set; }
  
  public IObjectEmbed? ObjectEmbed { get ; set; }
  
  public IObjectLink? ObjectLink { get ; set; }
  
}
