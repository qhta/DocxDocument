namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaBiLevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaCeiling))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaFloor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaInverse))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaModulationEffect))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaModulationFixed))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaOutset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaReplace))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBiLevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlend))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlur))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorChange))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorReplacement))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IDuotone))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectContainer))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffect))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillOverlay))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGlow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGrayscale))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHsl))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IInnerShadow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILuminanceEffect))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IOuterShadow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetShadow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IReflection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRelativeOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISoftEdge))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITintEffect))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITransformEffect))]
public class EffectContainer: IEffectContainer
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public EffectContainerValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
}
