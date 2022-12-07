namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public class HiddenEffectsPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>, HiddenEffectsProperties
{
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
