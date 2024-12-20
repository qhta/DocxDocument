namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public partial class PredecessorDrawingElementReferenceImpl: ModelElementImpl, PredecessorDrawingElementReference
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PredecessorDrawingElementReferenceImpl(): base() {}
  
  public PredecessorDrawingElementReferenceImpl(DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Pred
  {
    get => (System.String?)OpenXmlElement?.Pred?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pred = (System.String?)value;
    }
  }
  
}
