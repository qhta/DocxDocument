namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public class PredecessorDrawingElementReferenceImpl: ModelElementImpl, PredecessorDrawingElementReference
{
  public DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Pred
  {
    get => (String?)OpenXmlElement?.Pred?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pred = (System.String?)value;
    }
  }
  
}
