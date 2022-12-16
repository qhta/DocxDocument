namespace DocumentModel.Drawings;

/// <summary>
/// Effect Style List.
/// </summary>
public class EffectStyleListImpl: ModelElementImpl, EffectStyleList
{
  public DocumentFormat.OpenXml.Drawing.EffectStyleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectStyleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EffectStyleListImpl(): base() {}
  
  public EffectStyleListImpl(DocumentFormat.OpenXml.Drawing.EffectStyleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.EffectStyle? EffectStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyle>();
        if (item != null)
          return new DocumentModel.Drawings.EffectStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
