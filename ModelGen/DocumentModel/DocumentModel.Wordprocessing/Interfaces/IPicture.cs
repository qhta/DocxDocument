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
  
  public DocumentModel.Vml.IGroup? Group { get ; set; }
  
  public DocumentModel.Vml.IImageFile? ImageFile { get ; set; }
  
  public DocumentModel.Vml.ILine? Line { get ; set; }
  
  public DocumentModel.Vml.IOval? Oval { get ; set; }
  
  public DocumentModel.Vml.IPolyLine? PolyLine { get ; set; }
  
  public DocumentModel.Vml.IRectangle? Rectangle { get ; set; }
  
  public DocumentModel.Vml.IRoundRectangle? RoundRectangle { get ; set; }
  
  public DocumentModel.Vml.IShape? Shape { get ; set; }
  
  public DocumentModel.Vml.IShapetype? Shapetype { get ; set; }
  
  public DocumentModel.Vml.IArc? Arc { get ; set; }
  
  public DocumentModel.Vml.ICurve? Curve { get ; set; }
  
  public DocumentModel.Vml.Office.IOleObject? OleObject { get ; set; }
  
  public DocumentModel.Wordprocessing.IRelationshipType? MovieReference { get ; set; }
  
  public DocumentModel.Wordprocessing.IControl? Control { get ; set; }
  
}
