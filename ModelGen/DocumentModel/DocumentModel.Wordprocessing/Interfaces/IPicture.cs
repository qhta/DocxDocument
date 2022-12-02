namespace DocumentModel.Wordprocessing;

/// <summary>
/// VML Object.
/// </summary>
public interface IPicture // : DocumentModel.ITypedOpenXmlCompositeElement
{
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
  
  public IRelationshipType? MovieReference { get ; set; }
  
  public IControl? Control { get ; set; }
  
}
