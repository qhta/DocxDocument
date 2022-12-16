namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public class ParentLabelLayoutImpl: ModelElementImpl, ParentLabelLayout
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParentLabelLayoutImpl(): base() {}
  
  public ParentLabelLayoutImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ParentLabelLayoutVal? ParentLabelLayoutVal
  {
    get => (DocumentModel.Drawings.ChartDrawings.ParentLabelLayoutVal?)OpenXmlElement?.ParentLabelLayoutVal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ParentLabelLayoutVal = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal?)value;
    }
  }
  
}
