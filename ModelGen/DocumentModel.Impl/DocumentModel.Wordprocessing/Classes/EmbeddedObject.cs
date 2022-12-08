namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public class EmbeddedObjectImpl: ModelElementImpl, EmbeddedObject
{
  public DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// dxaOrig
  /// </summary>
  public String? DxaOriginal
  {
    get;
    set;
  }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  public String? DyaOriginal
  {
    get;
    set;
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
  
  public Drawing? Drawing
  {
    get;
    set;
  }
  
  public Control? Control
  {
    get;
    set;
  }
  
  public ObjectEmbed? ObjectEmbed
  {
    get;
    set;
  }
  
  public ObjectLink? ObjectLink
  {
    get;
    set;
  }
  
}
