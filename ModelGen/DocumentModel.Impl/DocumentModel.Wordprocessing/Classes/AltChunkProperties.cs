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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MatchSource>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.MatchSource{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
