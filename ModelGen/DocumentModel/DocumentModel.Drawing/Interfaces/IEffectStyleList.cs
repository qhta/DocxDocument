namespace DocumentModel.Drawing;

/// <summary>
/// Effect Style List.
/// </summary>
public interface IEffectStyleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IEffectStyle>? EffectStyles { get ; set; }
  
}
