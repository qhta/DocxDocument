namespace DocumentModel.Drawing;

/// <summary>
/// Effect Style List.
/// </summary>
public interface IEffectStyleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IEffectStyle>? EffectStyles { get ; set; }
  
}
