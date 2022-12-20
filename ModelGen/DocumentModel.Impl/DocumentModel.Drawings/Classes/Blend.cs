namespace DocumentModel.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public partial class BlendImpl: ModelElementImpl, Blend
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Blend? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Blend?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BlendImpl(): base() {}
  
  public BlendImpl(DocumentFormat.OpenXml.Drawing.Blend openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blend Mode
  /// </summary>
  public DocumentModel.Drawings.BlendMode? BlendMode
  {
    get => (DocumentModel.Drawings.BlendMode?)OpenXmlElement?.BlendMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlendMode = (DocumentFormat.OpenXml.Drawing.BlendModeValues?)value;
    }
  }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public DocumentModel.Drawings.EffectContainer? EffectContainer
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
        if (item != null)
          return new DocumentModel.Drawings.EffectContainerImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectContainerImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
