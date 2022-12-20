namespace DocumentModel.Drawings;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public partial class AlphaModulationEffectImpl: ModelElementImpl, AlphaModulationEffect
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.AlphaModulationEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaModulationEffect?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AlphaModulationEffectImpl(): base() {}
  
  public AlphaModulationEffectImpl(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// EffectContainer.
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
