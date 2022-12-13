namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public class HiddenEffectsPropertiesImpl: ModelElementImpl, HiddenEffectsProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HiddenEffectsPropertiesImpl(): base() {}
  
  public HiddenEffectsPropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public DocumentModel.Drawings.EffectList? EffectList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public DocumentModel.Drawings.EffectDag? EffectDag
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
