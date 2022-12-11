namespace DocumentModel.Drawings;

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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
