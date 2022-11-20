namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
public class HiddenEffectsProperties: IHiddenEffectsProperties
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  public IEffectList? EffectList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public IEffectDag? EffectDag
  {
    get;
    set;
  }
  
}
