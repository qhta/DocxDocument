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
  
  public Collection<NumberingPictureBullet>? NumberingPictureBullets
  {
    get;
    set;
  }
  
  public Collection<AbstractNum>? AbstractNums
  {
    get;
    set;
  }
  
  public Collection<NumberingInstance>? NumberingInstances
  {
    get;
    set;
  }
  
  public Int32? NumberingIdMacAtCleanup
  {
    get;
    set;
  }
  
}
