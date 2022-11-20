namespace DocumentModel.Drawing;

/// <summary>
/// Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
public interface IEffectPropertiesType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  public IEffectList? EffectList { get ; set; }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public IEffectDag? EffectDag { get ; set; }
  
}
