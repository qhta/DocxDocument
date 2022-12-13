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
  
  public EmbeddedObjectImpl(): base() {}
  
  public EmbeddedObjectImpl(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// dxaOrig
  /// </summary>
  public String? DxaOriginal
  {
    get => (System.String?)OpenXmlElement?.DxaOriginal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DxaOriginal = (System.String?)value;
    }
  }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  public String? DyaOriginal
  {
    get => (System.String?)OpenXmlElement?.DyaOriginal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DyaOriginal = (System.String?)value;
    }
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? AnchorId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Group? Group
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.ImageFile? ImageFile
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Line? Line
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Oval? Oval
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.PolyLine? PolyLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Rectangle? Rectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.RoundRectangle? RoundRectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Shapetype? Shapetype
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Arc? Arc
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.Curve? Curve
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.OleObject? OleObject
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawing? Drawing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Control? Control
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.ObjectEmbed? ObjectEmbed
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.ObjectLink? ObjectLink
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
