namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public class ParentLabelLayoutImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>, ParentLabelLayout
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public ParentLabelLayoutVal? ParentLabelLayoutVal
  {
    get => (ParentLabelLayoutVal?)OpenXmlElement?.ParentLabelLayoutVal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ParentLabelLayoutVal = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal?)value;
    }
  }
  
}
