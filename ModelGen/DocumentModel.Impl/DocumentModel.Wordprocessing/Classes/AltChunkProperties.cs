namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
public class AltChunkPropertiesImpl: ModelElementImpl, AltChunkProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AltChunkPropertiesImpl(): base() {}
  
  public AltChunkPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  public Boolean? MatchSource
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MatchSource>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MatchSource>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.MatchSource();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
