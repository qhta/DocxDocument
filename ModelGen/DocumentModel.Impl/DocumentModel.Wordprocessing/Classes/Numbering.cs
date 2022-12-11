namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public class NumberingImpl: ModelElementImpl, Numbering
{
  public DocumentFormat.OpenXml.Wordprocessing.Numbering? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Numbering?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingImpl(): base() {}
  
  public NumberingImpl(DocumentFormat.OpenXml.Wordprocessing.Numbering openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<NumberingPictureBullet>? NumberingPictureBullets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<AbstractNum>? AbstractNums
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<NumberingInstance>? NumberingInstances
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Int32? NumberingIdMacAtCleanup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
