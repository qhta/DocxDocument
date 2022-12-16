namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FullReference Class.
/// </summary>
public class FullReferenceImpl: ModelElementImpl, FullReference
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FullReferenceImpl(): base() {}
  
  public FullReferenceImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences
  {
    get => (System.String?)OpenXmlElement?.SequenceOfReferences?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SequenceOfReferences != null)
        {
          if (value is not null)
            OpenXmlElement.SequenceOfReferences.Text = value;
          else
            OpenXmlElement.SequenceOfReferences = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SequenceOfReferences = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences{ Text = value };
        }
      }
    }
  }
  
}
