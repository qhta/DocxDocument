namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
public class LevelReferenceImpl: ModelElementImpl, LevelReference
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LevelReferenceImpl(): base() {}
  
  public LevelReferenceImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference openXmlElement): base(openXmlElement)
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
