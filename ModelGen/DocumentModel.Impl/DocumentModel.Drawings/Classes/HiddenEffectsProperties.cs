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
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public EffectList? EffectList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public EffectDag? EffectDag
  {
    get;
    set;
  }
  
}
