namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public class RsidsImpl: ModelElementImpl, Rsids
{
  public DocumentFormat.OpenXml.Wordprocessing.Rsids? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Rsids?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public DocumentModel.HexWord? RsidRoot
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>();
        return (DocumentModel.HexWord?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (string?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.RsidRoot{ Val = (string?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.HexWord>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
