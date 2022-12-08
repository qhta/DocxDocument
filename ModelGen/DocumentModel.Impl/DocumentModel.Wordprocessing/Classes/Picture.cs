namespace DocumentModel.Wordprocessing;

/// <summary>
/// VML Object.
/// </summary>
public class PictureImpl: ModelElementImpl, Picture
{
  public DocumentFormat.OpenXml.Wordprocessing.Picture? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Picture?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? AnchorId
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Group>? Groups
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.ImageFile>? ImageFiles
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Line>? Lines
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Oval>? Ovals
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.PolyLine>? PolyLines
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Rectangle>? Rectangles
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.RoundRectangle>? RoundRectangles
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Shape>? Shapes
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Shapetype>? Shapetypes
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Arc>? Arcs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.Curve>? Curves
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.OleObject>? OleObjects
  {
    get;
    set;
  }
  
  public RelationshipType? MovieReference
  {
    get;
    set;
  }
  
  public Control? Control
  {
    get;
    set;
  }
  
}
